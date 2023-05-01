#region Includes
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Desafio.TecnicoLLip.Infrastructure.Data.Utils;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository;
using System.Linq;
using System.Collections.Generic;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base
{

    public abstract class BaseRepositorio<TEntity> : IDisposable, IRepository<TEntity> 
        where TEntity : Domain.Models.Base.Base
    {
        #region Properties
        protected TEntity Entity { get; set; }
        protected DbSet<TEntity> _dbSet;
        public DbContext Contexto { get; set; }
        public string Method { get; set; }
        protected Expression<Func<TEntity, bool>> Filter { get; set; }
        #endregion

        public TEntity LoadRecursive(TEntity item, Expression<Func<TEntity, IEnumerable<TEntity>>> loadSelector)
        {
            Contexto
                .Entry(item)
                .Collection(loadSelector)
                .Load();

            foreach (var child in loadSelector.Compile().Invoke(item))
                LoadRecursive(child, loadSelector);

            return item;
        }

        public virtual void Initialized(DbContext contexto)
        {
            Contexto = contexto;
            _dbSet = contexto.Set<TEntity>();
        }

        protected BaseRepositorio(DbContext contexto)
        {
            Contexto = contexto;
            _dbSet = contexto.Set<TEntity>();
        }

        private void Validate()
        {
            var entities = Contexto.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
                .Select(e => e.Entity)
                .ToList();

            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext, validateAllProperties: true);
            }
        }

        private Task<TEntity> SaveChanges(TEntity item , string action = nameof(SaveChanges))
        {
            var objResult = ObjectResult<TEntity>.Instance;
            objResult.Append($"{action} {item?.GetType().FullName}");
            try
            {
                Validate();
                Contexto.SaveChanges();
            }
            catch (ValidationException valExc)
            {
                objResult.Append($"{action} validation exception: {valExc?.Message}", valExc);       
            }
            catch(DbUpdateException dbUpEx)
            {
                dbUpEx.SetException(ref objResult, action);                
            }
            catch (Exception ex)
            {
                ex.SetException(ref objResult, action);
            }
            finally
            {
                if (objResult.IsError)
                {
                    item?.ValidationResult.Errors.Add(new ValidationFailure("DBError", objResult.Messages?.ToString()));
                }

                objResult.Append(item);

            }

            return Task.FromResult(item);
        }

        public virtual Task<TEntity> Adicionar(TEntity item)
        {
            Contexto.Entry(item).State = EntityState.Added;
            return SaveChanges(_dbSet.Add(item).Entity, nameof(Adicionar));
        }

        public virtual Task<TEntity> Atualizar(TEntity item)
        {
            Contexto.Entry(item).State = EntityState.Modified;

            return SaveChanges(_dbSet.Update(item).Entity, nameof(Atualizar));
        }

        public virtual Task<TEntity> Remover(TEntity item)
        {
            Contexto.Entry(item).State = EntityState.Modified;

            return SaveChanges(_dbSet.Remove(item).Entity, nameof(Remover));
        }

        public virtual async Task<TEntity> Remover(object id)
        {
            var item = await _dbSet.FindAsync(id);

            Contexto.Entry(item).State = EntityState.Deleted;

            return _dbSet.Remove(item).Entity;
        }

        public virtual async Task<TEntity> ObtemPorId(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<TEntity, bool>> filtro, int qtd, int pule, IEnumerable<string> includes)
        {
            IQueryable<TEntity> result = _dbSet;
            if (filtro != null)
                result = result.Where(filtro);

            if (!string.IsNullOrEmpty(colunaOrdenacao))
                result = result.OrderBy(colunaOrdenacao, asc ?? true);

            if (pule > 0)
                result = result.Skip(pule);

            if (qtd > 0)
                result = result.Take(qtd);

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    result = result.Include(include);

            return await result.ToListAsync();
        }

        public virtual async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> expression, IEnumerable<string> includes)
        {
            IQueryable<TEntity> result = _dbSet;

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    result = result.Include(include);

            return await result.FirstOrDefaultAsync(expression);
        }

        public virtual async Task<bool> Any(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public virtual async Task<bool> All(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.AllAsync(expression);
        }
       
        public PropetyStruct<object> Proptruct { get; set; }

        public T GetParamOutPutValue<T>() where T : struct
        {
            return (T)Proptruct?.Value;
        }
        
        #region IDisposable Support
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Contexto?.Dispose();
            }
        }

        public Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> expression, IEnumerable<string> includes = null)
        {
            throw new NotImplementedException();
        }

        ~BaseRepositorio()
        {
            Dispose(false);
        }
        #endregion
    }
}
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Desafio.TecnicoLLip.Infrastructure.Data.Utils;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.SGE;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base
{

    public abstract class BaseRepositorio<TEntity> : IDisposable, IRepository<TEntity> 
        where TEntity : Domain.Models.Base.Base
    {
        #region Properties
        protected TEntity Entity { get; set; }
        protected SgeContext _SGEContexto;
        protected DbSet<TEntity> _dbSet;
        protected ArrayList _parameters;
        public DbContext Contexto { get; set; }
        public string Method { get; set; }
        private ILoggerRepository Logger { get; set; }
        protected ArrayList Parameters
        {
            get
            {
                if (_parameters == null)
                {
                    _parameters = new LlipParameters<string, object>();
                }

                return _parameters;
            }
        }
        protected string StoredProcedure { get; set; }
        protected Expression<Func<TEntity, bool>> Filter { get; set; }
        #endregion

        protected void AddStroredProcedure(string storedProcedure)
        {
            StoredProcedure = storedProcedure;
        }

        protected SqlParameter AddParameters(string name, object value, ParameterDirection direction = ParameterDirection.Input, bool IsNullable = true)
        {
            var parameter = new SqlParameter(name, value ?? DBNull.Value) { Direction = direction, IsNullable = IsNullable };

            if(value != DBNull.Value && !(value is null))
                parameter.SqlDbType = SqlHelper.GetDbType(value);

            Parameters.Add(parameter);

            return parameter;
        }

        protected void AddParameters(TEntity entity, string method)
        {
            Method = method;
            Entity = entity;
            ObjectResult<TEntity>.Instance.Append(entity);
        }

        protected void AddParameters(TEntity entity)
        {
            Entity = entity;
            ObjectResult<TEntity>.Instance.Append(entity);
        }

        protected void AddParameters(string method)
        {
            Method = method;
        }

        protected void ClearParameters()
        {
            ObjectResult<TEntity>.Instance.Destroy();
            Parameters?.Clear();
            Method = string.Empty;
            Entity = null;
        }

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

        public virtual void Initialized(DbContext contexto, SgeContext sgeContexto)
        {
            _parameters?.Clear();
            Contexto = contexto;
            _dbSet = contexto.Set<TEntity>();
            _SGEContexto = sgeContexto;
            ClearParameters();
        }

        protected BaseRepositorio(DbContext contexto)
        {
            _parameters?.Clear();
            Contexto = contexto;
            _dbSet = contexto.Set<TEntity>();
            ClearParameters();
        }

        protected BaseRepositorio(DbContext contexto, ILoggerRepository logger)
        {
            _parameters?.Clear();
            Contexto = contexto;
            _dbSet = contexto.Set<TEntity>();
            Logger = logger;
            ClearParameters();
        }

        protected BaseRepositorio(DbContext contexto, SgeContext sgeContexto)
        {
            _parameters?.Clear();
            Contexto = contexto;
            _SGEContexto = sgeContexto;
            _dbSet = contexto.Set<TEntity>();
            ClearParameters();
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

        private Task<TEntity> SaveChanges(TEntity item, bool log = true, string action = nameof(SaveChanges))
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

                if (log)
                    SaveLogger(objResult);
            }

            return Task.FromResult(item);
        }

        private void SaveLogger(ObjectResult<TEntity> objResult)
        {
            Logger.Save(objResult.Logger);
        }

        public virtual Task<TEntity> Adicionar(TEntity item)
        {
            Contexto.Entry(item).State = EntityState.Added;
            return SaveChanges(_dbSet.Add(item).Entity,true, nameof(Adicionar));
        }

        public virtual Task<TEntity> Atualizar(TEntity item)
        {
            Contexto.Entry(item).State = EntityState.Modified;

            return SaveChanges(_dbSet.Update(item).Entity, true, nameof(Atualizar));
        }

        public virtual Task<TEntity> Remover(TEntity item)
        {
            Contexto.Entry(item).State = EntityState.Modified;

            return SaveChanges(_dbSet.Remove(item).Entity, true, nameof(Remover));
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

        public virtual IQueryable<TEntity> QueryableFilter(string colunaOrdenacao, bool? asc, Expression<Func<TEntity, bool>> filtro, int qtd, int pule, IEnumerable<string> includes)
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

            return result;
        }

        public virtual IQueryable<TEntity> QueryableFirstOrDefault(Expression<Func<TEntity, bool>> expression, IEnumerable<string> includes)
        {
            IQueryable<TEntity> result = _dbSet;

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    result = result.Include(include);

            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> expression, IEnumerable<string> includes = default)
        {
            IQueryable<TEntity> result = _dbSet;

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    result = result.Include(include);

            return await result.Where(expression).ToListAsync().ConfigureAwait(true);
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

        private object[] GetParameters(StringBuilder spSignature)
        {
            object[] spParameters;
            var addParameters = _parameters.Cast<SqlParameter>().ToList();
            bool hasTableVariables = addParameters.Any(p => p.SqlDbType == SqlDbType.Structured);
            var length = addParameters.Count - 1;

            if (hasTableVariables)
            {
                var tableValueParameters = new List<SqlParameter>();

                for (int i = 0; i < addParameters.Count; i++)
                {
                    switch (addParameters[i].SqlDbType)
                    {
                        case SqlDbType.Structured:
                            spSignature.AppendFormat("@{0}", addParameters[i].ParameterName);
                            tableValueParameters.Add(addParameters[i]);
                            break;
                        case SqlDbType.VarChar:
                        case SqlDbType.Char:
                        case SqlDbType.Text:
                        case SqlDbType.NVarChar:
                        case SqlDbType.NChar:
                        case SqlDbType.NText:
                        case SqlDbType.Xml:
                        case SqlDbType.UniqueIdentifier:
                        case SqlDbType.Time:
                        case SqlDbType.Date:
                        case SqlDbType.DateTime:
                        case SqlDbType.DateTime2:
                        case SqlDbType.DateTimeOffset:
                        case SqlDbType.SmallDateTime:
                            spSignature.AppendFormat("'{0}'", addParameters[i].Value.ToString());
                            break;
                        default:
                            spSignature.AppendFormat("{0}", addParameters[i].Value.ToString());
                            break;
                    }

                    if (i != length) spSignature.Append(",");
                }
                spParameters = tableValueParameters.Cast<object>().ToArray();
            }
            else
            {
                for (int i = 0; i < addParameters.Count; i++)
                {
                    spSignature.AppendFormat(" @{0} {1}", addParameters[i].ParameterName, addParameters[i].Direction == ParameterDirection.Output ? "out" : string.Empty);
                    if (i != length) spSignature.Append(",");
                }
                spParameters = _parameters.Cast<object>().ToArray();
            }

            return spParameters;
        }
        
        public PropetyStruct<object> Proptruct { get; set; }

        public T GetParamOutPutValue<T>() where T : struct
        {
            return (T)Proptruct?.Value;
        }

        public T SetParamOutPutValue<T>() where T : struct
        {
            SqlParameter param = new SqlParameter();

            if (_parameters.Count > 0)
            {
                param = _parameters.Cast<SqlParameter>().FirstOrDefault(p => p.Direction == ParameterDirection.Output);
            }

            if (param != null)
            {
                param.Value.TryCast(out T result);
                Proptruct = result;
                return result;
            }

            return default;
        }
 
        public ObjectResult<TEntity> ExecuteStoredProcedure(string method = nameof(Adicionar))
        {
            return ExecuteStoredAsync(true, method).Result;
        }

        public async Task<ObjectResult<TEntity>> ExecuteStoredAsync(bool log = true, string method = nameof(Adicionar))
        {
            var spSignature = new StringBuilder();
            spSignature.AppendFormat("EXECUTE {0}", StoredProcedure);
            var spParameters = GetParameters(spSignature);
            var objResult = ObjectResult<TEntity>.Instance;            
            objResult.Append($"{Method??method} {Entity?.GetType().FullName}",Entity);
            try
            {
                objResult.Result = Contexto.Database.ExecuteSqlRaw(spSignature.ToString(), spParameters);
            }
            catch (ValidationException exc)
            {
                objResult.Append($"{nameof(SaveChanges)} validation exception: {exc?.Message}",exc);
            }
            catch (Exception ex)
            {
                if (ex.GetBaseException().GetType() == typeof(SqlException))
                {
                    objResult.Append(ex.InnerException != null ? ((SqlException)ex.InnerException).Number : ((SqlException)ex).Number);

                    switch (objResult.ErrorCod)
                    {
                        case 2627:
                            ObjectResult<TEntity>.Instance.Append($"{nameof(SaveChanges)} validation exception Unique constraint error", ex);
                            break;
                        case 547:
                            ObjectResult<TEntity>.Instance.Append($"{nameof(SaveChanges)} validation exception Constraint check violation", ex);
                            break;
                        case 2601:
                            ObjectResult<TEntity>.Instance.Append($"{nameof(SaveChanges)} validation exception Duplicated key row error", ex);
                            break;
                        case 229:
                            ObjectResult<TEntity>.Instance.Append($"{nameof(SaveChanges)} The UPDATE permission was denied on the object", ex);
                            break;
                        default:
                            break;
                    }

                    if (objResult.IsError)
                    {
                        objResult.Append($"{nameof(SaveChanges)} Message: {((SqlException)ex).Message}", ex, ((SqlException)ex).Number);
                    }
                }
            }
            finally
            {
                if (objResult.IsError)
                {
                    Entity.ValidationResult.Errors.Add(new ValidationFailure("DBError", objResult.Messages?.ToString()));
                }

                objResult.Append(Entity);

                if (log)
                {
                    SetParamOutPutValue<int>();

                   SaveLogger(objResult);                    
                }
            }            

            return objResult;
         }

        public virtual async Task<TEntity> ExecuteQuery(string query, IEnumerable<string> includes = null)
        {
            var spSignature = new StringBuilder();

            spSignature.AppendFormat("EXECUTE sp_executesql({0})", query);

            var spParameters = GetParameters(spSignature);

            var result = _dbSet.FromSqlRaw(spSignature.ToString(), spParameters);

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    result = result.Include(include);

            return await result.SingleOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> ExecuteQuery(string query, Expression<Func<TEntity, bool>> filtro = null)
        {
            var spSignature = new StringBuilder();

            spSignature.AppendFormat("EXECUTE sp_executesql({0})", query);

            var result = ExecuteStoredQueryable(query);

            if (filtro != null)
                result = result.Where(filtro);

            return await result.ToListAsync();
        }

        public virtual async Task<TEntity> ExecuteStoredSingle(string storedProcedureName, IEnumerable<string> includes = null)
        {
            var spSignature = new StringBuilder();

            spSignature.AppendFormat("EXECUTE {0}", storedProcedureName);

            var spParameters = GetParameters(spSignature);

            var result = _dbSet.FromSqlRaw(spSignature.ToString(), spParameters);

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    result = result.Include(include);

            return await result.SingleOrDefaultAsync();
        }

        public virtual IQueryable<TEntity> ExecuteStoredQueryable(string storedProcedureName)
        {
            var spSignature = new StringBuilder();
            spSignature.AppendFormat("EXECUTE {0}", storedProcedureName);
            var spParameters = GetParameters(spSignature);

            return _dbSet.FromSqlRaw(spSignature.ToString(), spParameters).AsQueryable();
        }

        public virtual async Task<IEnumerable<TEntity>> ExecuteStoredQuery(string storedProcedureName, Expression<Func<TEntity, bool>> filtro)
        {
            var result = ExecuteStoredQueryable(storedProcedureName);

            if (filtro != null)
                result = result.Where(filtro);

            return await result.ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> ExecuteStoredQuery(string storedProcedureName, IEnumerable<string> includes = null)
        {
            IQueryable<TEntity> dbSet = _dbSet;

            if (includes != null && includes.Any())
                foreach (var include in includes)
                    dbSet = dbSet.Include(include);

            var spSignature = new StringBuilder();

            spSignature.AppendFormat("EXECUTE {0}", storedProcedureName);

            var spParameters = GetParameters(spSignature);

            var result = _dbSet.FromSqlRaw(spSignature.ToString(), spParameters);

            return await result.AsNoTracking().ToListAsync();
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
                _parameters?.Clear();
            }
        }

        ~BaseRepositorio()
        {
            Dispose(false);
        }
        #endregion
    }
}
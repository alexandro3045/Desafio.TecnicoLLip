using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Base;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Domain.Services.Base
{
    public abstract class BaseService<T> : IDisposable, IService<T> where T : Models.Base.Base
    {
        #region Properties dispose
        private bool isDisposed { get; set; }
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);
        #endregion

        protected readonly IRepository<T> Repository;

        private readonly AbstractValidator<T> Validator;

        protected BaseService(IRepository<T> repository, AbstractValidator<T> validator = null)
        {
            Repository = repository;
            Validator = validator;
        }

        private IList<ValidationFailure> Validate(ref T entity) 
        {
            if (Validator == null)
                throw new ArgumentException("Validator cannot be null into insert action");

            var errors = Validator.Validate(entity).Errors;

            entity.ValidationResult = new ValidationResult(errors);
                
            return errors;
        }

        public Task<T> Adicionar(T entity)
        {
            if (Validate(ref entity).Count > 0)
            {
                return Task.FromResult<T>(entity);
            }

            return Repository.Adicionar(entity);
        }

        public Task<T> Atualizar(T entity)
        {
            if (Validate(ref entity).Count > 0)
            {
                return Task.FromResult<T>(entity);
            }

            return Repository.Atualizar(entity);
        }

        public Task<IEnumerable<T>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<T, bool>> filtro, int qtd, int pule, IEnumerable<string> includes)
        {
            return Repository.ComFiltros(colunaOrdenacao, asc, filtro, qtd, pule, includes);
        }

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> filtro, IEnumerable<string> includes)
        {
            return Repository.FirstOrDefault(filtro, includes);
        }

        public Task<T> Remover(T entity)
        {
            if (Validate(ref entity).Count > 0)
            {
                return Task.FromResult<T>(entity);
            }

            return Repository.Remover(entity);
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
                ((IDisposable)Repository).Dispose();
            }

            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            isDisposed = true;
        }

        ~BaseService()
        {
            Dispose(false);
        }
        #endregion
    }
}

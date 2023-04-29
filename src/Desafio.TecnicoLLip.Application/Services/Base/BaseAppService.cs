using AutoMapper;
using Desafio.TecnicoLLip.Application.Interfaces.Base;
using Desafio.TecnicoLLip.Application.Utils;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Application.Services.Base
{
    public abstract class BaseAppService<E, V> : IDisposable, IAppService<V>
        where E : Domain.Models.Base.Base
        where V : ViewModels.Base.Base
    {
        #region Properties dispose
        private bool isDisposed { get; set; }
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);
        #endregion

        protected readonly IMapper Mapper;
        protected readonly IService<E> BaseService;
        protected readonly IEnumerable<string> Includes;
        protected readonly Expression<Func<V, bool>> Expression;
        protected readonly Expression<Func<V, bool>> Instance = c => true;
        
        protected BaseAppService(IMapper mapper, IService<E> baseService, IEnumerable<string> includes = null, Expression<Func<V, bool>> expression = null)
        {
            Mapper = mapper;
            BaseService = baseService;
            Includes = includes??Enumerable.Empty<string>();
            Expression = expression;
        }

        public virtual Task<V> Adicionar(V itemViewModel)
        {
            var itemMap = Mapper.Map<V,E>(itemViewModel);
            var item = BaseService.Adicionar(itemMap);
            return Mapper.MapAsync<E,V>(item);
        }

        public virtual Task<V> Atualizar(V itemViewModel)
        {
            var itemMap = Mapper.Map<V,E>(itemViewModel);
            var item = BaseService.Atualizar(itemMap);
            return Mapper.MapAsync<E, V>(item);
        }

        public virtual Task<IEnumerable<V>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<V, bool>> filtro, int qtd, int pule)
        {
            if (Expression != null)
            {
                if (filtro == null)
                    filtro = Instance;

                filtro = CombineFunction.Combine(filtro, Expression);
            }
            using var retorno = BaseService.ComFiltros(colunaOrdenacao, asc, filtro.ConvertExpression<V, E>(), qtd, pule, Includes);
            var res = retorno.Result;
            return Task.FromResult(Mapper.Map<IEnumerable<E>, IEnumerable<V>>(res));
        }

        public virtual Task<V> FirstOrDefault(Expression<Func<V, bool>> filtro, IEnumerable<string> includes = null)
        {
            using var retorno = BaseService.FirstOrDefault(filtro.ConvertExpression<V, E>(), includes ?? Includes);
            var res = retorno.Result;
            return Task.FromResult(Mapper.Map<E, V>(res));
        }

        public Task<V> Remover(V itemViewModel)
        {
            var itemMap = Mapper.Map<V,E>(itemViewModel);
            var item = BaseService.Remover(itemMap);
            return Mapper.MapAsync<E, V>(item);
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
               ((IDisposable)BaseService).Dispose();
            }

            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            isDisposed = true;
        }

        ~BaseAppService()
        {
            Dispose(false);
        }
        #endregion
    }
}

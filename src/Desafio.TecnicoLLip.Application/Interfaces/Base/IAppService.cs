﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Application.Interfaces.Base
{
    public interface IAppService<V>  where V : ViewModels.Base.Base
    {
        Task<V> Adicionar(V itemViewModel);
        Task<V> Atualizar(V itemViewModel);
        Task<IEnumerable<V>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<V, bool>> filtro, int qtd, int pule);
        Task<V> FirstOrDefault(Expression<Func<V, bool>> filtro, IEnumerable<string> includes = null);
        Task<V> Remover(V itemViewModel);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Adicionar(TEntity item);
        Task<TEntity> Remover(TEntity item);
        Task<TEntity> Remover(object id);
        Task<TEntity> Atualizar(TEntity item);
        Task<TEntity> ObtemPorId(object id);
        Task<IEnumerable<TEntity>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<TEntity, bool>> filtro, int qtd,
            int pule, IEnumerable<string> includes);
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> expression, IEnumerable<string> includes = default);
        Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> expression, IEnumerable<string> includes);
        Task<bool> Any(Expression<Func<TEntity, bool>> expression);
        Task<bool> All(Expression<Func<TEntity, bool>> expression);
    }
}
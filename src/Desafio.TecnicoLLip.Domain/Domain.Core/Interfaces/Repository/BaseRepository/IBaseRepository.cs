namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository
{
    public interface IBaseRepository<TEntity> : IRepository<TEntity> where TEntity : class { }
}

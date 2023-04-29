using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Protheus;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Protheus
{
    public class ProtheusRepositorio<TEntity> : BaseRepositorio<TEntity> where TEntity : Domain.Models.Base.Base
    {
        public ProtheusRepositorio(ProtheusContext context) : base(context) { }
    }
}
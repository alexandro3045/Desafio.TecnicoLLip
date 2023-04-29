using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.SRC
{
    public class SrcRepositorio<TEntity> : BaseRepositorio<TEntity> where TEntity : Domain.Models.Base.Base
    {
        public SrcRepositorio(CorporativoContext context) : base(context) { }
    }
}
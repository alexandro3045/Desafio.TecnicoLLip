using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class TipoEntidadeVinculoRepositorio : BaseRepositorio<TipoEntidadeVinculo>, ITipoEntidadeVinculoRepository
    {
        public TipoEntidadeVinculoRepositorio(CorporativoContext context) : base(context) { }
    }
}
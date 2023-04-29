using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class TipoServicoRepositorio : BaseRepositorio<TipoServico>
    {
        public TipoServicoRepositorio(CorporativoContext context) : base(context) { }
    }
}
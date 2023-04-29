using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class GrupoProdutoRepositorio : BaseRepositorio<GrupoClassificacao>
    {
        public GrupoProdutoRepositorio(CorporativoContext context) : base(context) { }
    }
}
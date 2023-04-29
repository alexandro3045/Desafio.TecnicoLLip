using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.SRC
{
    public class EntidadeRepositorio : SrcRepositorio<Entidade>, IEntidadeRepository
    {
        public EntidadeRepositorio(CorporativoContext context) : base(context) { }
    }
}
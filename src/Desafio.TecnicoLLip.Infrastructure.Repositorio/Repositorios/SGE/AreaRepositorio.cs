using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.SGE;
using Desafio.TecnicoLLip.Domain.Models.SGE;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.SGE;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.SGE
{
    public class AreaRepositorio : SgeRepositorio<Area>, IAreaRepository
    {
        public AreaRepositorio(SgeContext context) : base(context) { }
    }
}
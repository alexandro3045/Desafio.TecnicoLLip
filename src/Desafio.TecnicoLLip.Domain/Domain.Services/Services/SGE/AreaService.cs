using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.SGE;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.SGE;
using Desafio.TecnicoLLip.Domain.Models.SGE;
using Desafio.TecnicoLLip.Domain.Services.Base;

namespace Desafio.TecnicoLLip.Domain.Services.SGE
{
    public class AreaService : BaseService<Area>, IAreaService
    {
        public AreaService(IAreaRepository repository) : base(repository) { }
    }
}

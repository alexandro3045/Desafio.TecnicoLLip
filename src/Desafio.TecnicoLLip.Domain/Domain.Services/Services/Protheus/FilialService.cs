using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Protheus;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Domain.Services.Base;

namespace Desafio.TecnicoLLip.Domain.Services.Protheus
{
    public class FilialService : BaseService<Filial>, IFilialService
    {
        public FilialService(IFilialRepository repository) : base(repository) { }
    }
}

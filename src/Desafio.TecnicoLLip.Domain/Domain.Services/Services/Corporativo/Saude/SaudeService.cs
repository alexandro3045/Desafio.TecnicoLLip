using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Saude;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class SaudeService : BaseService<Models.Corporativo.Gestor.Saude>, ISaudeService
    {
        public SaudeService(ISaudeRepository repository, SaudeValidator validator) : base(repository, validator) { }
    }
}

using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.SRC
{
    public class EntidadeService : BaseService<Entidade>, IEntidadeService
    {
        public EntidadeService(IEntidadeRepository repository, EntidadeValidator validator) : base(repository, validator) { }
    }
}

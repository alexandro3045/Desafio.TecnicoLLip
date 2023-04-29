using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.SMAIS;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.SMAIS;
using Desafio.TecnicoLLip.Domain.Models.SMAIS;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.SMAIS;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class ExameService : BaseService<Exame>, IExameService
    {
        public ExameService(IExameRepository repository, ExameValidator validator) : base(repository, validator) { }
    }
}

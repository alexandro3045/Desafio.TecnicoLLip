using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.STI;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.STI
{
    public class ClassificacaoServicoService : BaseService<ClassificacaoServico>, IClassificacaoServicoService
    {
        public ClassificacaoServicoService(IClassificacaoServicoRepository repository, ClassificacaoServicoValidator validator) : base(repository, validator) { }
    }
}
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Protheus;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Protheus;

namespace Desafio.TecnicoLLip.Domain.Services.Protheus
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        public EmpresaService(IEmpresaRepository repository, EmpresaValidator validator) : base(repository, validator) { }
    }
}

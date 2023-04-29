using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;
using System.Collections.Generic;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class EmpresaEntidadeVinculoService : BaseService<EmpresaEntidadeVinculo>, IEmpresaEntidadeVinculoService
    {
        private new readonly IEmpresaEntidadeVinculoRepository _repository;
        public EmpresaEntidadeVinculoService(IEmpresaEntidadeVinculoRepository repository, EmpresaEntidadeVinculoValidator validator) : base(repository, validator)
        {
            _repository = repository;
        }

        public IEnumerator<string> GetTiposEntidadesVinculosIds(string empresaId)
        {
            return _repository.GetTiposEntidadesVinculosIds(empresaId);
        }
    }
}

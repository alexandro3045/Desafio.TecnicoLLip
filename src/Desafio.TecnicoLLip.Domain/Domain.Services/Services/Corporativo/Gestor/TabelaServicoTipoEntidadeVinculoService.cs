using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class TabelaServicoTipoEntidadeVinculoService : BaseService<TabelaServicoTipoEntidadeVinculo>, ITabelaServicoTipoEntidadeVinculoService
    {
        new readonly ITabelaServicoTipoEntidadeVinculoRepository _repository;
        public TabelaServicoTipoEntidadeVinculoService(ITabelaServicoTipoEntidadeVinculoRepository repository,
            TabelaServicoTipoEntidadeVinculoValidator validator) : base(repository, validator)
        {
            _repository = repository;
        }

        public Task<IEnumerable<TabelaServicoTipoEntidadeVinculo>> GetTabelasServicos(string CodigoTipoEntidadeVinculo)
        {
            return _repository.GetTabelasServicos(CodigoTipoEntidadeVinculo);
        }
    }
}

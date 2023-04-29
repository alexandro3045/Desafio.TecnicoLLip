using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor
{
    public interface ITabelaServicoTipoEntidadeVinculoService : IService<TabelaServicoTipoEntidadeVinculo>
    {
        Task<IEnumerable<TabelaServicoTipoEntidadeVinculo>> GetTabelasServicos(string CodigoTipoEntidadeVinculo);
    }
}

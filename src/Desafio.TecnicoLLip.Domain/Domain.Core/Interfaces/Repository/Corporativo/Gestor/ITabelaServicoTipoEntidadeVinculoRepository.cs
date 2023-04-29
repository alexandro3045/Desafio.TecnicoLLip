using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor
{
    public interface ITabelaServicoTipoEntidadeVinculoRepository : IBaseRepository<TabelaServicoTipoEntidadeVinculo>
    {
        Task<IEnumerable<TabelaServicoTipoEntidadeVinculo>> GetTabelasServicos(string CodigoTipoEntidade);
    }
}

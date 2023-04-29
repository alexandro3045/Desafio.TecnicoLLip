using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using System.Collections.Generic;

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor
{
    public interface IEmpresaEntidadeVinculoRepository : IBaseRepository<EmpresaEntidadeVinculo>
    {
        IEnumerator<string> GetTiposEntidadesVinculosIds(string empresaId);
    }
}

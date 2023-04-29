using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using System.Collections.Generic;

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor
{
    public interface IEmpresaEntidadeVinculoService : IService<EmpresaEntidadeVinculo> 
    {
        IEnumerator<string> GetTiposEntidadesVinculosIds(string empresaId);
    }
}

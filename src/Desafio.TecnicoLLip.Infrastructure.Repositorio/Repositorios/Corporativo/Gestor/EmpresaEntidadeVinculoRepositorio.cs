using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using System.Collections.Generic;
using System.Linq;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class EmpresaEntidadeVinculoRepositorio : BaseRepositorio<EmpresaEntidadeVinculo>, IEmpresaEntidadeVinculoRepository
    {
        public EmpresaEntidadeVinculoRepositorio(CorporativoContext context) : base(context) { }

        public IEnumerator<string> GetTiposEntidadesVinculosIds(string empresaId)
        {
            return ((CorporativoContext)Contexto).EmpresasEntidadesVinculos.Where(s => s.EmpresaId == empresaId).Select(s => s.TipoEntidadeVinculoId).GetEnumerator();
        }
    }
}
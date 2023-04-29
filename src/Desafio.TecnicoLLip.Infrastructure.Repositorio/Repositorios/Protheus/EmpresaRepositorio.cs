using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Protheus
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepository
    {
        public EmpresaRepositorio(CorporativoContext context) : base(context) { }
    }
}
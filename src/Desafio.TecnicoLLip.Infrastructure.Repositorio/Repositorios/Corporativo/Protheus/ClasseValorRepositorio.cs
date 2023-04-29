using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Protheus
{
    public class ClasseValorRepositorio : BaseRepositorio<ClasseValor>, IClasseValorRepository
    {
        public ClasseValorRepositorio(CorporativoContext context) : base(context) { }
    }
}
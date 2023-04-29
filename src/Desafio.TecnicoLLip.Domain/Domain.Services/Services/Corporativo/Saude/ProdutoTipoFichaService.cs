using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Saude;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Saude
{
    public class ProdutoTipoFichaService : BaseService<ProdutoTipoFicha>, IProdutoTipoFichaService
    {
        public ProdutoTipoFichaService(IProdutoTipoFichaRepository repository, ProdutoTipoFichaValidator validator) : base(repository, validator) { }
    }
}

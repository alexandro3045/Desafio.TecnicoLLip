using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class ContaContabilProdutoService : BaseService<ContaContabilProduto>, IContaContabilProdutoService
    {
        public ContaContabilProdutoService(IContaContabilProdutoRepository repository, ContaContabilProdutoValidator validator) : base(repository, validator) { }
    }
}

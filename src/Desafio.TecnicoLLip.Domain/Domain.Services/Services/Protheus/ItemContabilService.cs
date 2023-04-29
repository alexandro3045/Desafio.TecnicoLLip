using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Protheus;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Domain.Services.Base;

namespace Desafio.TecnicoLLip.Domain.Services.Protheus
{
    public class ItemContabilService : BaseService<ItemContabil>, IItemcontabilService
    {
        public ItemContabilService(IItemContabilRepository repository) : base(repository) { }
    }
}

using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Saude;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class TipoFichaService : BaseService<TipoFicha>, ITipoFichaService
    {
        public TipoFichaService(ITipoFichaRepository repository, TipoFichaValidator validator) : base(repository, validator) { }
    }
}

using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.SRC
{
    public class RegiaoUnidadeNegocioService : BaseService<RegiaoUnidadeNegocio>, IRegiaoUnidadeNegocioService
    {
        public RegiaoUnidadeNegocioService(IRegiaoUnidadeNegocioRepository repository, RegiaoUnidadeNegocioValidator validator) : base(repository, validator) { }
    }
}

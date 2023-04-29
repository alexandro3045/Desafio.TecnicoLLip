using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class ModuloVersaoService : BaseService<ModuloVersao>, IModuloVersaoService
    {
        public ModuloVersaoService(IModuloVersaoRepository repository, ModuloVersaoValidator validator) : base(repository, validator) { }
    }
}

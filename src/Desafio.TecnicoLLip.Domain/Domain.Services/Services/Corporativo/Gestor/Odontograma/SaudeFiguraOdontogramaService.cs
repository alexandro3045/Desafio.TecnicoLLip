using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor.Odontograma
{
    public class SaudeFiguraOdontogramaService : BaseService<SaudeFiguraOdontograma>, ISaudeFiguraOdontogramaService
    {
        public SaudeFiguraOdontogramaService(ISaudeFiguraOdontogramaRepository repository, SaudeFiguraOdontogramaValidator validator) 
            : base(repository, validator) { }
    }
}

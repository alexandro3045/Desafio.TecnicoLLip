using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor.Odontograma
{
    public class FiguraOdontogramaService : BaseService<FiguraOdontograma>, IFiguraOdontogramaService
    {
        public FiguraOdontogramaService(IFiguraOdontogramaRepository repository, FiguraOdontogramaValidator validator) : base(repository, validator) { }
    }
}

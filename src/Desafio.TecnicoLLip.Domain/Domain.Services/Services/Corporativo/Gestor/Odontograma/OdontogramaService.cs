using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor;


namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor.Odontograma
{
    public class OdontogramaService : BaseService<Models.Corporativo.Gestor.Odontograma.Odontograma>, IOdontogramaService
    {
        public OdontogramaService(IOdontogramaRepository repository, OdontogramaValidator validator) : base(repository, validator)
        {
        }
    }
}

using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor.Odontograma
{
    public class SaudeFiguraOdontogramaRepositorio : BaseRepositorio<SaudeFiguraOdontograma>, ISaudeFiguraOdontogramaRepository
    {
        public SaudeFiguraOdontogramaRepositorio(CorporativoContext context) : base(context) { }
    }
}
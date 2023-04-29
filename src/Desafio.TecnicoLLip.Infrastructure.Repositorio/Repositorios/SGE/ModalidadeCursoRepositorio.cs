using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.SGE;
using Desafio.TecnicoLLip.Domain.Models.SGE;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.SGE;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.SGE
{
    public class ModalidadeCursoRepositorio : SgeRepositorio<ModalidadeCurso>, IModalidadesRepository
    {
        public ModalidadeCursoRepositorio(SgeContext context) : base(context) { }
    }
}
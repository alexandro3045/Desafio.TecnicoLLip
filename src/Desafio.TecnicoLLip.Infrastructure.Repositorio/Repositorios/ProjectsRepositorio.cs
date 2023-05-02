#region Includes
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository;
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios
{
    public class ProjectsRepositorio : BaseRepositorio<Projects>, IProjectsRepository
    {
        public ProjectsRepositorio(DesafioLlipContext context) : base(context) { }
    }
}
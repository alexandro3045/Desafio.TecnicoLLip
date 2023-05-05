#region Includes
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services;
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Services.Validations;
using System.Collections.Generic;
#endregion

namespace Desafio.TecnicoLLip.Domain.Services.Services
{
    public class ProjectsService : BaseService<Projects>, IProjectsService
    {
        public ProjectsService(IProjectsRepository repository, ProjectsValidator validator) : base(repository, validator) { }
    }
}

#region Includes
using AutoMapper;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Services.Base;
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services;
using Desafio.TecnicoLLip.Domain.Models;
#endregion

namespace Desafio.TecnicoLLip.Application.Services
{
    public class ProjetoAppService : BaseAppService<Project, ProjetoViewModel>, IProjetoAppService
    {
        public static readonly string[] includes = { "Activities", "Activities.Resposavel" };
        public ProjetoAppService(IMapper mapper, IProjectsService projectsService) : base(mapper, projectsService, includes) { }
    }
}

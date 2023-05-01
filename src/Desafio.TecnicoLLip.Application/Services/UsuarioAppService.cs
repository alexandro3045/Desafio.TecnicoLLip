#region Includes
using AutoMapper;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Services.Base;
using Desafio.TecnicoLLip.Application.Utils;
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services;
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using ServiceStack.DataAnnotations;
using System.Linq;
#endregion

namespace Desafio.TecnicoLLip.Application.Services
{
    public class UsuarioAppService : BaseAppService<Users, UsuarioViewModel>, IUsuarioAppService
    {
        public UsuarioAppService(IMapper mapper, IUsersService usersService) : base(mapper, usersService) { }
    }
}

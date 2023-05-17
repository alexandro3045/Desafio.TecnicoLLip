#region Includes
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.API.Crud;
using Desafio.TecnicoLLip.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Desafio.TecnicoLLip.API.Controllers
{
    ///<Summary>
    /// Class UsuariosController
    ///</Summary>
    [Route("api/[controller]/{version}")]
    public class UsuariosController : Base<UsuarioViewModel, int>
    {
        public UsuariosController(IUsuarioAppService appService) : base(appService) { }
       
    }
}
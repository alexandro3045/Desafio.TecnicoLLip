#region Includes
using Desafio.TecnicoLLip.API.Base.Crud;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Desafio.TecnicoLLip.API.Controllers
{
    ///<Summary>
    /// Class UsuariosController
    ///</Summary>
    [Route("api/[controller]/{version}")]
    public class ProjetosController : Base<ProjetoViewModel>
    {
        public ProjetosController(IProjetoAppService appService) : base(appService,"Id") { }
    }
}
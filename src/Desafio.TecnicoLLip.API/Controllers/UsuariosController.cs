#region Includes
using Desafio.TecnicoLLip.API.Crud;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Utils;
using Desafio.TecnicoLLip.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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
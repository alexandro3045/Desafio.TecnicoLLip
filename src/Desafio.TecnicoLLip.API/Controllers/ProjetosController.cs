#region Includes
using Desafio.TecnicoLLip.API.Base.Crud;
using Desafio.TecnicoLLip.API.Crud;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Utils;
using Desafio.TecnicoLLip.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
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
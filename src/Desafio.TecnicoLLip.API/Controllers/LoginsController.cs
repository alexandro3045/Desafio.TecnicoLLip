#region Includes
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Desafio.TecnicoLLip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly Application.Interfaces.ILoginAppService _loginAppService;

        public LoginsController(Application.Interfaces.ILoginAppService loginAppService) => _loginAppService = loginAppService;

        /// <summary>
        /// Retorna token que autentica e autoriza as aplicações a consumirem os métodos de consulta da API do RH
        /// </summary>
        /// <param name="user">Login e chave de acesso fornecidos pelo app (audiência) requisitante para consumo da API</param>
        /// <response code="403">Acesso não autorizado: login e/ou chave de acesso inválido(s)</response>
        /// <response code="400">Formato da requisição é inválido</response>
        /// <response code="200">Retorna token de acesso que autoriza a aplicação requisitante a consumir a API</response>  
        [HttpPost]
        [ProducesResponseType(typeof(Token), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult Post([FromBody] UserApi user)       {
            var retorno = _loginAppService.Login(user.Email, user.Senha);

            if (!retorno.Autenticated)
                return StatusCode(StatusCodes.Status400BadRequest, retorno);
            else
                return Ok(new
                {
                    success = true,
                    objecto = retorno
                });
        }
    }
}
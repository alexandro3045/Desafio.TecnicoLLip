#region Includes
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Domain.Models.Utility;
#endregion

namespace Desafio.TecnicoLLip.Application.Interfaces
{
    public interface ILoginAppService
    {
        Token ObterPorLogin(UserApi user);
        Token ObterToken(UsuarioViewModel user);
        Token Login(string email, string senha);
    }
}
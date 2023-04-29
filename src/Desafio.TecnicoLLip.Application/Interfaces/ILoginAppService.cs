using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Application.Interfaces
{
    public interface ILoginAppService
    {
        Token ObterPorLogin(User user);
    }
}
using Desafio.TecnicoLLip.Domain.Models;

namespace Desafio.TecnicoLLip.Application.Interfaces
{
    public interface IEmailAppService
    {
        void SendEmail(Logger logger);
    }
}

using Desafio.TecnicoLLip.Domain.Models.Corporativo;

namespace Desafio.TecnicoLLip.Application.Interfaces
{
    public interface IEmailAppService
    {
        void SendEmail(Logger logger);
    }
}

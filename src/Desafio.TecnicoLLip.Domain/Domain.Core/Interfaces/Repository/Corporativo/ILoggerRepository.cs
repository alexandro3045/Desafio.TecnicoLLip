using Desafio.TecnicoLLip.Domain.Models.Corporativo;

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo
{
    public interface ILoggerRepository 
    {
       void Save(Logger logger);
    }
}

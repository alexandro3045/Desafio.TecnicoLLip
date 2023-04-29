using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.SMAIS;
using Desafio.TecnicoLLip.Domain.Models.SMAIS;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.SMAIS
{
    public class RiscoRepositorio : SMaisRepositorio<Risco>, IRiscoRepository
    {
        private static string urlRiscos => "https://ws1.soc.com.br/WebSoc/exportadados?parametro={'empresa':'521019','codigo':'25086','chave':'382edb4563feb2937cfc','tipoSaida':'json','empresaTrabalho':'521019'}";

        public RiscoRepositorio() : base(urlRiscos) { }
    }
}
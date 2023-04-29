using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SRC
{
    [Order(31)]
    public class RegiaoTest  : Operations
    {
        public RegiaoTest()
        {
            Body = new { TipoRegiaoId = 1, Descricao = $"TESTE TDD {RandTest}" };
            Configure("Regioes", "1");
        }
    }
}

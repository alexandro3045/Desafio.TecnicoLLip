using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SRC
{
    [Order(30)]
    public class EntidadeTest  : Operations
    {
        public EntidadeTest()
        {
            Body = new { Id = "9", Descricao = $"TESTE TDD 9" };
            Configure("SRC/Entidades", "1");
        }
    }
}

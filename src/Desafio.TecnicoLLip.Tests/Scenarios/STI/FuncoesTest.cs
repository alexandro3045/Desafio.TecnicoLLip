using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.STI
{
    [Order(37)]
    public class FuncoesTest  : Operations
    {
        public FuncoesTest() => Configure("Funcoes", "ATT");
    }
}

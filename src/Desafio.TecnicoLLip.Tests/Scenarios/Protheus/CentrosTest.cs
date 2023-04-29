using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Protheus
{
    [Order(21)]
    public class CentrosTest  : Operations
    {
        public CentrosTest() => Configure("Protheus/CentrosCustos", "01011010100");
    }
}

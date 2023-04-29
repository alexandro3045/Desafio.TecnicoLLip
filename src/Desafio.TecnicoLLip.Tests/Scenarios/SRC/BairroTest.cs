using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SRC
{
    [Order(29)]
    public class BairroTest  : Operations
    {
        public BairroTest()
        {
            Configure("Bairros", "1");
        }
    }
}

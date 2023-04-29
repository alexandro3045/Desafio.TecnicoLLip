using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.STI
{
    [Order(35)]
    public class AreaTest  : Operations
    {
        public AreaTest() => Configure("STI/Areas", "1");
    }
}

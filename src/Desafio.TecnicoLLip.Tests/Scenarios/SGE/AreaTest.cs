using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SGE
{
    [Order(27)]
    public class AreaTest  : Operations
    {
        public AreaTest() => Configure("AreasSGE", "1");
    }
}

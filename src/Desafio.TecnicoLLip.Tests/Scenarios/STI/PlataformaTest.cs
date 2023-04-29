using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.STI
{
    [Order(39)]
    public class PlataformaTest  : Operations
    {
        public PlataformaTest() => Configure("STI/Plataformas", "1");
    }
}

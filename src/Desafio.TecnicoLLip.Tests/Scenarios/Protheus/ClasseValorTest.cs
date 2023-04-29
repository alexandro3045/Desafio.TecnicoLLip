using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Protheus
{
    [Order(22)]
    public class ClasseValorTest  : Operations
    {
        public ClasseValorTest() => Configure("ClassesValores", "1010191,01RJ");
    }
}

using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Protheus
{
    [Order(25)]
    public class FilialTest  : Operations
    {
        public FilialTest() => Configure("Gestor/Protheus/Filiais", "01RJ0001");
    }
}

using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Protheus
{
    [Order(24)]
    public class ContaContabilTest  : Operations
    {
        public ContaContabilTest() => Configure("ContasContabeis", "41010401001");
    }
}

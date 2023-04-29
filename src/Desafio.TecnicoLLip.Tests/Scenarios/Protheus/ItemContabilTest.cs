using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Protheus
{
    [Order(26)]
    public class ItemContabilTest  : Operations
    {
        public ItemContabilTest() => Configure("ItensContabeis", "3110723");
    }
}

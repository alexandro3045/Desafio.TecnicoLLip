using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.STI
{
    [Order(38)]
    public class LinhaServicoTest  : Operations
    {
        public LinhaServicoTest() => Configure("STI/LinhasServicos", "1");
    }
}

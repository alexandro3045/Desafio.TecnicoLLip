using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.STI
{
    [Order(36)]
    public class ClassificacaoServicoTest  : Operations
    {
        public ClassificacaoServicoTest() => Configure("STI/ClassificacoesServicos", "1");
    }
}

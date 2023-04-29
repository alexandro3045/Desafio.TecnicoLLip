using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(10)]
    public class EnderecoUnidadeTest  : Operations
    {
        public EnderecoUnidadeTest() => Configure("EnderecosUnidades", "1");
    }
}

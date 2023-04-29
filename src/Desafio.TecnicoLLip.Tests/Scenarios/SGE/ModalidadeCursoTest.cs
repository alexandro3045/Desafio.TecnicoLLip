using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SGE
{
    [Order(28)]
    public class ModalidadesCursosTest  : Operations
    {
        public ModalidadesCursosTest() => Configure("ModalidadesCursos", "57");

        public void GetByColigada()
        {
            Get("byColigada/3");
        }
    }
}

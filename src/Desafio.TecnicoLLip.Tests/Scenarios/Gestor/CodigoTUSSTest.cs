using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(8)]
    public class CodigoTussTest  : Operations
    {
        public CodigoTussTest()
        {
            Body = new
            {
                Codigo = "9999999999",
                Descricao = $"DESCRIÇÂO TDD {RandTest}"
            };
            Configure("Gestor/Tuss", "2");
        }
    }
}

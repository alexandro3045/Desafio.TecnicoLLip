using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(17)]
    public class TipoEntidadeVinculoTest  : Operations
    {
        public TipoEntidadeVinculoTest()
        {
            Body = new
            {
                Id = 99,
                Descricao = $"TESTE TDD {RandTest}",
                ValidationResult = new {}
            };

            Configure("Gestor/TiposEntidades", "3");
        }
    }
}
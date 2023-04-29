using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SRC
{
    [Order(33)]
    public class TipoRegiaoTest  : Operations
    {
        public TipoRegiaoTest()
        {
            Configure("TiposRegioes", "1");
            Body = new
            {
                Descricao = $"TESTE TDD {RandTest}",
            };
        }
    }
}

using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(20)]
    public class TipoUnidadeNegocioTest  : Operations
    {
        public TipoUnidadeNegocioTest()
        {
            Body = new
            {
                Sigla = "TESTETDD",
                Descricao = $"TESTE TDD {RandTest}",
                UnidadeVinculada = new
                {
                    Id = 'S',
                    Name = "Sim"
                }
            };
            Configure("Gestor/TiposUnidadesNegocios", "18");
        }
    }
}

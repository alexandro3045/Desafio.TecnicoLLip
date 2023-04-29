using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(14)]
    public class ProdutoTipoFichaTest  : Operations
    {
        public ProdutoTipoFichaTest()
        {
            Body = new
            {
                ProdutoId = 46,
                TipoFichaId = 3,
                GeraAtendimento = new
                {
                    Id = 'N',
                    Name = "Não"
                },
                ServicoId = 36
            };

            Configure("Gestor/Saude/ProdutosTiposFichas", "46,36,17");
        }
    }
}
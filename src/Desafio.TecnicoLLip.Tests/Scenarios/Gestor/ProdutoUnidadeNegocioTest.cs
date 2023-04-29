using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(15)]
    public class ProdutoUnidadeNegocioTest  : Operations
    {
        public ProdutoUnidadeNegocioTest()
        {
            Body = new
            {
                Inicio = DateTime.ParseExact("2024-03-08 14:41:00", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.ParseExact("2024-03-09 14:45:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                ProdutoId = 41664,
                UnidadeNegocioId = 287,
                ExecutaServicoOferecido = 'S'
            };

            Configure("ProdutosUnidadesNegocios", "342276");
        }
    }
}
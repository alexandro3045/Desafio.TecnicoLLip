using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(5)]
    public class ClasseValorProdutoTest  : Operations
    {
        public ClasseValorProdutoTest()
        {
            Body = new
            {
                CodigoEmpresa = "003",
                CodigoCentroResponsabilidade = "3900709",
                ProdutoId = 2720,
                Inicio = DateTime.Parse("2024-03-06 14:40:52", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.Parse("2028-03-06 14:40:52", System.Globalization.CultureInfo.InvariantCulture),
            };
            Configure("ClassesValoresProdutos", "04RJ,DOTRE0059,45547", "ProdutoId");
        }

        public override void PostTest()
        {
            base.Post();

            AssertMethod();

            base.SendPut();

            base.Delete();
        }
    }
}

using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(11)]
    public class ItemContabilProdutoTest  : Operations
    {
        public ItemContabilProdutoTest()
        {
            Body = new
            {
                CodigoEmpresa = "003",
                CodigoCentroResponsabilidade = "390070902",
                ProdutoId = 2720,
                Inicio = DateTime.ParseExact("2020-03-11 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.ParseExact("2024-03-11 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
            };

            Configure("ItemsContabeisProdutos", "02RJ,320020300,46097", "ProdutoId");
        }

        public override void PutTest()
        {
            base.Post();

            base.Put();

            AssertMethod();

            base.Delete();
        }

        public override void DeleteTest()
        {
            base.Post();

            base.Put();

            base.Delete();

            AssertMethod();
        }
    }
}

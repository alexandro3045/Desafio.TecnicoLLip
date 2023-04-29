using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(9)]
    public class ContaContabilProdutoTest  : Operations
    {
        public ContaContabilProdutoTest()
        {
            Body = new
            {
                CodigoEmpresa = "01RJ",
                CodigoConta = "040208",
                ProdutoId = 38693,
                Inicio = DateTime.ParseExact("2024-10-11 14:40:00", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim =    DateTime.ParseExact("2024-10-11 14:40:00", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                IsAssistencial = 'S'
            };
            Configure("ContasContabeisProdutos", "01RJ,040208,36,2019-06-11 14:40:52", "ProdutoId");
        }

        public override void DeleteTest()
        {
            base.Post();

            AssertMethod();

            base.SendPut();

            base.Delete();
        }

        public override void PostTest()
        {
            DeleteTest();
        }
    }
}

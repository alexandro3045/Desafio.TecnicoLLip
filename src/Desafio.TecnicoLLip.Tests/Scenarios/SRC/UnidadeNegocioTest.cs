using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SRC
{
    [Order(34)]
    public class UnidadeNegocioTest  : Operations
    {
        public UnidadeNegocioTest()
        {
            Body = new
            {
                Inicio = DateTime.ParseExact("2020-03-13 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.ParseExact("2024-03-13 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                AceitaPreco = true,
                AutorizaDivulgacao = false,
                AtendimentoCentralizado = true,
                AtivoAssistMarca = false,
                AtivoOcupMarca = false,
                AtivoOcupDesMarca = false,
                TipoUnidadeId = 8,
                FazFaturamento = true,
                EmpresaSistemaCNICoordenadoraId = 954,
                DescricaoAbreviado = $"TESTE TDD {RandTest}",
                Sigla = $"AMA{RandTest}",
                Prestador = "N",
                Corporativo = "N",
                Descricao = $"TESTE TDD {RandTest}"
            };

            Configure("Gestor/UnidadesNegocios", "1");
        }

        public override void PutTest()
        {
            base.Post();

            base.Put();

            AssertMethod();
        }

        public override void PostTest()
        {
            AssertMethod();
        }

        public override void DeleteTest()
        {
            SendTest(System.Net.Http.HttpMethod.Delete);
        }
    }
}

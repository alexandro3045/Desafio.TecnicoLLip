using LlipTests.Scenarios.Base.CRUD;
using System;
using System.Net.Http;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(6)]
    public class CodigoMunicipalServicoCorporativoTest : Operations
    {
        public CodigoMunicipalServicoCorporativoTest()
        {
            Body = new
            {
                CodigoServicoOficial = 36,
                CodigoMunicipalId = "3304557",
                CodigoMunicipio = "330455",
                SeqMunicipio = 79,
                Inicio = DateTime.ParseExact("2020-02-17 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.ParseExact("2024-02-17 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            };
            Configure("CodigosMunicipaisServicosCorporativos", "3304557,47", "CodigoMunicipalId");
        }

        public override void PostTest()
        {
            SendTest(HttpMethod.Post);
            AssertMethod();
            SendTest(HttpMethod.Put);
            SendTest(HttpMethod.Delete);
        }

        public override void DeleteTest()
        {
            PostTest();
        }
    }
}

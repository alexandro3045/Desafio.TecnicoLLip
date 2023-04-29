using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.SRC
{
    [Order(32)]
    public class RegiaoUnidadeNegocioTest  : Operations
    {
        public RegiaoUnidadeNegocioTest()
        {
            Configure("RegioesUnidadesNegocios", null, "RegiaoId",null, "4,25,395");
            Body = new
            {
                RegiaoId = 25,
                TipoRegiaoId = 4,
                UnidadeNegocioId = 292,
                Inicio = DateTime.ParseExact("2020-03-06 14:40:00", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.ParseExact("2024-03-06 14:40:00", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
            };
        }
    }
}

using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(18)]
    public class TipoEntTipoUnidNeg  : Operations
    {
        public TipoEntTipoUnidNeg()
        {
            Body = new
            {
                Id = 99,
                TipoUnidadeNegocioId = Int16.Parse("1"),
                TipoEntidadeVinculoId = "7"
            };
            Configure("Gestor/TiposEntidadesTiposUnidadesNegocios", "24");
        }
    }
}

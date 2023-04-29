using LlipTests.Scenarios.Base.Query;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Protheus
{
    [Order(23)]
    public class CodigoEmpresaTest  : Operations
    {
        public CodigoEmpresaTest() => Configure("Gestor/Protheus/CodigosEmpresas", "01RJ0001");
    }
}

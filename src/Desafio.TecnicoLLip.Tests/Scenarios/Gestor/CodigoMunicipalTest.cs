using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(7)]
    public class CodigoMunicipalTest  : Operations
    {
        public CodigoMunicipalTest()
        {
            Body = new
            {
                Id = "010101",
                CoodigoMunicipio = "3304557",
                Descricao = $"ANÁLISE DE SISTEMAS                               ",
                MunicipioId = 79,
                AliqISS = 0.5,
                CNAE = "8599698"
            };
            Configure("Gestor/CodigosMunicipais", "010101");
        }
    }
}

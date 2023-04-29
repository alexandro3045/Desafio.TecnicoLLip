using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor.Odontograma
{
    [Order(4)]
    public class SaudeFiguraOdontoTest : Operations
    {
        public SaudeFiguraOdontoTest()
        {
            Body = new
            {
                SaudeId = 482,
                FiguraOdontogramaId = 40
            };
            Configure("Gestor/Odontograma/SaudesFigurasOdontogramas", "482,5");
        }
    }
}
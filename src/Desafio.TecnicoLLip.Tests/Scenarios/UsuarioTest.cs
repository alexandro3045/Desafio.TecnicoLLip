using LlipTests.Scenarios.Base.CRUD;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor.Odontograma
{
    [Order(1)]
    public class UsuarioTest : Operations
    {
        public UsuarioTest()
        {
            Body = new
            {
                Name = "aaaaaaa",
                Email = "a@a.com.br",
                Password = "aaaaaaaa"
            };
            Configure("Projetos", "1");
        }
    }
}
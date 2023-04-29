using LlipTests.Scenarios.Base.CRUD;
using System.Dynamic;
using Xunit;
using Xunit.Extensions.Ordering;
using Xunit.Priority;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor.Odontograma
{
    [Order(2)]
    public class FiguraOdontogramaTest : Operations
    {
        public FiguraOdontogramaTest()
        {
            Body = new ExpandoObject();
            
            Body.TipoFigura = new
            {
                Id = "I",
                Name = "Realizado fora do SESI"
            };
            Body.Image = "AAABAAEAIiIQAAAAAAAgBAAAFgAAACgAAAAiAAAARAAAAAEABAAAAAAAuAMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAAACAAAAAgIAAgAAAAIAAgACAgAAAwMDAAICAgAAAAP8AAP8AAAD//wD/AAAA/wD/AP//AAD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAzMzMzMzMzAAAAAAAAAAAAAAAAAzMzMzMzMzMwAAAAAAAAAAAAAAAzMzMzMzMzMzMAAAAAAAAAAAAAAzMzMzMzMzMzMzAAAAAAAAAAAAAzMzMzMzMzMzMzMwAAAAAAAAAAAzMzMzMzMzMzMzMzMAAAAAAAAAAzMzMzMzMzMzMzMzMzAAAAAAAAAzMzMzMzMzMzMzMzMzMwAAAAAAAzMzMzMzMzMzMzMzMzMzMAAAAAAzMzMzMzMzMzMzMzMzMzMzAAAAAzMzMzMzMzMzMzMzMzMzMzMwAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/////8AAAAD/////wAAAAP/////AAAAA/8AA/8AAAAD/gAB/wAAAAP8AAD/AAAAA/gAAH8AAAAD8AAAPwAAAAPgAAAfAAAAA8AAAA8AAAADgAAABwAAAAMAAAADAAAAAgAAAAEAAAAAAAAAAAAAAAAA=";
            Body.Local = new
            {
                Id = "C",
                Name = "Coroa"
            };
            Body.Tamanho = 0.0;
            Body.Face1 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Face2 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Face3 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Face4 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Face5 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Raiz1 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Raiz2 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Raiz3 = new
            {
                Id = "S",
                Name = "Sim"
            };
            Body.Descricao = "Restauração";
            Body.Id = 9998;
            
            Configure("Gestor/Odontograma/FigurasOdontogramas", "1");
        }

        [Fact, Priority(6)]
        public virtual void PostValidImage()
        {
            Body.Image = null;

            SendPost();

            Assert.True(IsSuccess);

            SendDelete();
        }

        [Fact, Priority(7)]
        public virtual void PostValidFace()
        {
            Body.Face1 = null;
            Body.Face2 = new { Id = "N", Name = "Não" };
            Body.Face3 = new { Id = "N", Name = "Não" };
            Body.Face4 = new { Id = "N", Name = "Não" };
            Body.Face5 = new { Id = "N", Name = "Não" };

            SendPost();

            Assert.False(IsSuccess);

            SendDelete();
        }

        [Fact, Priority(8)]
        public virtual void PostValidRaiz()
        {
            Body.Raiz1 = new { Id = "N", Name = "Não" };
            Body.Raiz2 = new { Id = "N", Name = "Não" };
            Body.Raiz3 = new { Id = "N", Name = "Não" };

            SendPost();

            Assert.False(IsSuccess);

            SendDelete();
        }
    }
}

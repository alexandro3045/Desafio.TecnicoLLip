using LlipTests.Scenarios.Base.CRUD;
using System;
using System.Dynamic;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor.Odontograma
{
    [Order(3)]
    public class OdontogramaTest : Operations
    {
        public OdontogramaTest()
        {
            Body = new ExpandoObject();            
            Body.NumeroDente = 14;
            Body.Operacao = new { Id = "I", Name = "Identificado" };
            Body.AtendimentoId = "000120130018908";
            Body.Face2 = new { Id = "S", Name = "Sim" };
            Body.PessoaId = 2;
            Body.DataRadiografia = DateTime.ParseExact("2020-03-04 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            Body.FiguraOdontogramaId = 9999;

            Configure("Gestor/Odontograma/Odontogramas", "2548430,46,30");
        }

        public override void PostTest()
        {
            var Figura = new FiguraOdontogramaTest();

            Figura.SendPost();

            Body.FiguraOdontogramaId = Figura.Body.id.ToObject<int>();

            base.Post();

            base.Delete();

            Figura.SendDelete();
        }

        public override void PutTest()
        {
            DeleteTest();
        }

        public override void DeleteTest()
        {
            var Figura = new FiguraOdontogramaTest();

            Figura.SendPost();

            Body.FiguraOdontogramaId = Figura.Body.id.ToObject<int>();

            base.Post();

            base.Put();

            base.Delete();

            Figura.SendDelete();
        }

    }
}
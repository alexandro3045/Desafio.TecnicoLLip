using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Abrangencia : Enums<char?>
    {
        public static readonly  Abrangencia Unidade = new Abrangencia('U', "Unidade");
        public static readonly  Abrangencia Regional = new Abrangencia('R', "Regional");
        public static readonly  Abrangencia Estadual = new Abrangencia('E', "Estadual");
        public Abrangencia(char? key, string Name) : base(key, Name) { }
    }
}

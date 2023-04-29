using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Face : Enums<char?>
    {
        public static readonly  Face Sim = new Face('S', "Sim");
        public Face(char? key, string name) : base(key, name) { }
    }
}

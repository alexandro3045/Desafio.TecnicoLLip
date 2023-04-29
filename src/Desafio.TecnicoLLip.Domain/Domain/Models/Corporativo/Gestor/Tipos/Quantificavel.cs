
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Quantificavel : Enums<char?>
    {
        public static readonly  Quantificavel Sim = new Quantificavel('S', "Sim");
        public static readonly  Quantificavel Nao = new Quantificavel('N', "Não");
        public Quantificavel(char? key, string displayName) : base(key, displayName) { }
    }

}


using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Dedutivel : Enums<char?>
    {
        public static readonly  Dedutivel Sim = new Dedutivel('S', "Sim");
        public static readonly  Dedutivel Nao = new Dedutivel('N', "Não");
        public Dedutivel(char? key, string displayName) : base(key, displayName) { }
    }
}

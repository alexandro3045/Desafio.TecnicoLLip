
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class ObrigaArea : Enums<char?>
    {
        public static readonly  ObrigaArea Sim = new ObrigaArea('S', "Sim");
        public static readonly  ObrigaArea Nao = new ObrigaArea('N', "Não");
        public ObrigaArea(char? key, string displayName) : base(key, displayName) { }
    }

}

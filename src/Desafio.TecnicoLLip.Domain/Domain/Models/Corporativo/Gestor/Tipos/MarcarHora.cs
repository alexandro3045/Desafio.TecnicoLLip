
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class MarcarHora : Enums<char?>
    {
        public static readonly  MarcarHora Sim = new MarcarHora('S', "Sim");
        public static readonly  MarcarHora Nao = new MarcarHora('N', "Não");
        public MarcarHora(char? key, string displayName) : base(key, displayName) { }
    }

}


using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class UnidadeVinculada : Enums<char?>
    {
        public static readonly  UnidadeVinculada Sim = new UnidadeVinculada('S', "Sim");
        public static readonly  UnidadeVinculada Nao = new UnidadeVinculada('N', "Não");
        public UnidadeVinculada(char? key, string displayName) : base(key, displayName) { }
    }

}

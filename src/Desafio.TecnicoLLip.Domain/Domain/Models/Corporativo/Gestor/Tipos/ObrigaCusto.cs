using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class ObrigaCusto : Enums<char?>
    {
        public static readonly  ObrigaCusto Sim = new ObrigaCusto('S', "Sim");
        public static readonly  ObrigaCusto Nao = new ObrigaCusto('N', "Não");
        public ObrigaCusto(char? key, string displayName) : base(key, displayName) { }
    }

}

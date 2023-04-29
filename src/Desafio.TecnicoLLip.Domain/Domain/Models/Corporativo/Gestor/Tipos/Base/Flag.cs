using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Base
{
    public class Flag : Enums<char?>
    {
        public static readonly  Flag Sim = new Flag('S', "Sim");
        public static readonly  Flag Nao = new Flag('N', "Não");
        public static readonly  Flag Opcional = new Flag('O', "Opcional");
        public Flag(char? key, string displayName) : base(key, displayName) { }
    }
}

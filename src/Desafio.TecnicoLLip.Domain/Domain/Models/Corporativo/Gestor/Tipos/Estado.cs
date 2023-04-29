using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Estado : Enums<char?>
    {
        public static readonly  Estado Estudo = new Estado('E', "Estudo");
        public static readonly  Estado Aprovado = new Estado('A', "Aprovado");
        public static readonly  Estado NaoAprovado = new Estado('N', "Não Aprovado");
        public Estado(char? key, string displayName) : base(key, displayName) { }
    }
}

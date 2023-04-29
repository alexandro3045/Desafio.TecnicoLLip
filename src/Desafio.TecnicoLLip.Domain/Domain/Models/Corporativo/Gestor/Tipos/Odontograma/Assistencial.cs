using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Assistencial : Enums<char?>
    {
        public static readonly  Assistencial Sim = new Assistencial('S', "Sim");
        public static readonly  Assistencial Nao = new Assistencial('N', "Não");
        public Assistencial(char? key, string name) : base(key, name) { }
    }
}

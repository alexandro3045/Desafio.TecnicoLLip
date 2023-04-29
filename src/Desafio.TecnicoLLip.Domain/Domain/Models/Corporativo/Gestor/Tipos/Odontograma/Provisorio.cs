using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Provisorio : Enums<char?>
    {
        public static readonly  Provisorio Sim = new Provisorio('S', "Sim");
        public static readonly  Provisorio Nao = new Provisorio('N', "Não");
        public Provisorio(char? key, string name) : base(key, name) { }
    }
}

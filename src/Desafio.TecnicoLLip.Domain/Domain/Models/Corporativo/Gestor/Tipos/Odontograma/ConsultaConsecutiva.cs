using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class ConsultaConsecutiva : Enums<char?>
    {
        public static readonly  ConsultaConsecutiva Sim = new ConsultaConsecutiva('S', "Sim");
        public static readonly  ConsultaConsecutiva Nao = new ConsultaConsecutiva('N', "Não");
        public ConsultaConsecutiva(char? key, string name) : base(key, name) { }
    }
}

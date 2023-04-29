using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Extra : Enums<char?>
    {
        public static readonly  Extra Sim = new Extra('S', "Sim");
        public static readonly  Extra Nao = new Extra('N', "Não");
        public Extra(char? key, string name) : base(key, name) { }
    }
}

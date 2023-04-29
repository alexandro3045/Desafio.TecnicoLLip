
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class ValeCultura : Enums<char?>
    {
        public static readonly  ValeCultura Sim = new ValeCultura('S', "Sim");
        public static readonly  ValeCultura Nao = new ValeCultura('N', "Não");
        public ValeCultura(char? key, string displayName) : base(key, displayName) { }
    }

}

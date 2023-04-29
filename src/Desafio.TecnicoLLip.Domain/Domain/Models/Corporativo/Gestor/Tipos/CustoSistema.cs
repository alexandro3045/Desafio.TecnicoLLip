
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class CustoSistema : Enums<char?>
    {
        public static readonly  CustoSistema Sim = new CustoSistema('S', "Sim");
        public static readonly  CustoSistema Nao = new CustoSistema('N', "Não");
        public CustoSistema(char? key, string displayName) : base(key, displayName) { }
    }
}

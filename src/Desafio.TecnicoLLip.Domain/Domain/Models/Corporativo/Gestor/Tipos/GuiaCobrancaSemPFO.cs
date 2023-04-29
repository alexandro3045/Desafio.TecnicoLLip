using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class GuiaCobrancaSemPfo : Enums<char?>
    {
        public static readonly  GuiaCobrancaSemPfo Sim = new GuiaCobrancaSemPfo('S', "Sim");
        public static readonly  GuiaCobrancaSemPfo Nao = new GuiaCobrancaSemPfo('N', "Não");
        public GuiaCobrancaSemPfo(char? key, string displayName) : base(key, displayName) { }
    }
}

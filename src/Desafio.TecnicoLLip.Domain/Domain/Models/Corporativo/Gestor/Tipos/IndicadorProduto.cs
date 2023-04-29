
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class IndicadorProduto : Enums<char?>
    {
        public static readonly  IndicadorProduto Sim = new IndicadorProduto('S', "Sim");
        public static readonly  IndicadorProduto Nao = new IndicadorProduto('N', "Não");
        public IndicadorProduto(char? key, string displayName) : base(key, displayName) { }
    }

}

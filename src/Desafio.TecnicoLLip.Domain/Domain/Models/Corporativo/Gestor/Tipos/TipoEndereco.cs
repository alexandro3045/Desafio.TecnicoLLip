using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoEndereco : Enums<char?>
    {
        public static readonly  TipoEndereco Presencial = new TipoEndereco('P', "Proprio");
        public static readonly  TipoEndereco Distancia = new TipoEndereco('D', "Divulgado");
        public static readonly  TipoEndereco Web = new TipoEndereco('A', "Ambos");
        public static readonly  TipoEndereco Movel = new TipoEndereco('N', "Nenhum");
        public TipoEndereco(char? key, string displayName) : base(key, displayName) { }
    }
}

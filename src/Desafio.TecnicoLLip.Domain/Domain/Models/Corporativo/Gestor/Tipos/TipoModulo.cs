using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoModulo : Enums<char?>
    {
        public static readonly  TipoModulo Presencial = new TipoModulo('P', "Presencial");
        public static readonly  TipoModulo Distancia = new TipoModulo('D', "Distancia");
        public static readonly  TipoModulo Web = new TipoModulo('W', "Web");
        public static readonly  TipoModulo Movel = new TipoModulo('M', "Movel");
        public TipoModulo(char? key, string displayName) : base(key, displayName) { }
    }
}

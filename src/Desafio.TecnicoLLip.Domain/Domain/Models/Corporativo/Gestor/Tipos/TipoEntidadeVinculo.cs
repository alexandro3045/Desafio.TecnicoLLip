using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoEntidadeVinculo : Enums<string>
    {
        public static readonly  TipoEntidadeVinculo CIRJ = new TipoEntidadeVinculo("8", "CIRJ");
        public static readonly  TipoEntidadeVinculo FEDERACAO = new TipoEntidadeVinculo("5", "FEDERACAO");
        public static readonly  TipoEntidadeVinculo IEL = new TipoEntidadeVinculo("9", "IEL");
        public static readonly  TipoEntidadeVinculo SENAI = new TipoEntidadeVinculo("14", "SENAI-DR");
        public static readonly  TipoEntidadeVinculo SESI = new TipoEntidadeVinculo("12", "SESI-DR");
        public TipoEntidadeVinculo(string key, string displayName) : base(key, displayName) { }
        public bool IsIdEqualTo(string compareTo)
        {
            return (Id.Equals(compareTo));
        }
    }
}

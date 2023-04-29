using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoEntidade : Enums<char?>
    {
        public static readonly  TipoEntidade Llip = new TipoEntidade('1', "Llip");
        public static readonly  TipoEntidade Sesi = new TipoEntidade('2', "Sesi");
        public static readonly  TipoEntidade Senai = new TipoEntidade('3', "Senai");
        public static readonly  TipoEntidade IEL = new TipoEntidade('4', "IEL");
        public static readonly  TipoEntidade CIRJ = new TipoEntidade('5', "CIRJ");
        public TipoEntidade(char? key, string displayName) : base(key, displayName) { }
    }
}

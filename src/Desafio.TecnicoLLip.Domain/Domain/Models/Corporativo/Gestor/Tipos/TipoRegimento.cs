using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoRegimento : Enums<char?>
    {
        public static readonly  TipoRegimento Regimental = new TipoRegimento('1', "Regimental");
        public static readonly  TipoRegimento NaoRegimental = new TipoRegimento('2', "Não Regimental");
        public TipoRegimento(char? key, string displayName) : base(key, displayName) { }
    }
}

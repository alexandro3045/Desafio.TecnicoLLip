using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoUtilizacao : Enums<char?>
    {
        public static readonly  TipoUtilizacao Saude = new TipoUtilizacao('1', "Sistema de Saude");
        public static readonly  TipoUtilizacao SCA = new TipoUtilizacao('2', "SCA");
        public TipoUtilizacao(char? key, string displayName) : base(key, displayName) { }
    }
}

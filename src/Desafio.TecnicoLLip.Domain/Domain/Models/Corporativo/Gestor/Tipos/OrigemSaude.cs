using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class OrigemSaude : Enums<char?>
    {
        public static readonly  OrigemSaude MeioAmbiente = new OrigemSaude('A', "Assistencial");
        public static readonly  OrigemSaude AssistenciaSocial = new OrigemSaude('O', "Ocupacional");
        public static readonly  OrigemSaude Ambos = new OrigemSaude('B', "Ambos");
        public OrigemSaude(char? key, string displayName) : base(key, displayName) { }
    }
}

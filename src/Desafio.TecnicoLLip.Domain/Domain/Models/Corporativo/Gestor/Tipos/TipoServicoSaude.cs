using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoServicoSaude : Enums<char?>
    {
        public static readonly  TipoServicoSaude Procedimento = new TipoServicoSaude('P', "Procedimento");
        public static readonly  TipoServicoSaude Consulta = new TipoServicoSaude('C', "Consulta");
        public static readonly  TipoServicoSaude Nenhum = new TipoServicoSaude('N', "Nenhum");
        public TipoServicoSaude(char? key, string displayName) : base(key, displayName) { }
    }

}

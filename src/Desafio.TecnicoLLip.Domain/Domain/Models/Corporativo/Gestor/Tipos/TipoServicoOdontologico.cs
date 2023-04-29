using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoServicoOdontologico : Enums<char?>
    {
        public static readonly  TipoServicoOdontologico Inicial = new TipoServicoOdontologico('I', "Inicial");
        public static readonly  TipoServicoOdontologico Tratamento = new TipoServicoOdontologico('T', "Tratamento");
        public static readonly  TipoServicoOdontologico Urgencia = new TipoServicoOdontologico('U', "Urgência");
        public static readonly  TipoServicoOdontologico Complementar = new TipoServicoOdontologico('C', "Complementar");
        public static readonly TipoServicoOdontologico PreAgendamento = new TipoServicoOdontologico('P', "Pré-Agendamento");
        public TipoServicoOdontologico(char? key, string displayName) : base(key, displayName) { }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoServicoOdontologicoView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoServicoOdontologicoView Inicial = new TipoServicoOdontologicoView('I', "Inicial");
        [DataMember]
        public static readonly TipoServicoOdontologicoView Tratamento = new TipoServicoOdontologicoView('T', "Tratamento");
        [DataMember]
        public static readonly TipoServicoOdontologicoView Urgencia = new TipoServicoOdontologicoView('U', "Urgênciaa");
        [DataMember]
        public static readonly TipoServicoOdontologicoView Complementar = new TipoServicoOdontologicoView('C', "Complementar");
        [DataMember]
        public static readonly TipoServicoOdontologicoView PreAgendamento = new TipoServicoOdontologicoView('P', "Pré-Agendamento");

        public TipoServicoOdontologicoView(char? key, string displayName) : base(key, displayName) { }
    }
}

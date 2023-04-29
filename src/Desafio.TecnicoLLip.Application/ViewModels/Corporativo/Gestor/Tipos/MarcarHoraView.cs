
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class MarcarHoraView : Enums<char?>
    {
        [DataMember]
        public static readonly MarcarHoraView Sim = new MarcarHoraView('S', "Sim");
        [DataMember]
        public static readonly MarcarHoraView Nao = new MarcarHoraView('N', "Não");
        public MarcarHoraView(char? key, string displayName) : base(key, displayName) { }
    }

}

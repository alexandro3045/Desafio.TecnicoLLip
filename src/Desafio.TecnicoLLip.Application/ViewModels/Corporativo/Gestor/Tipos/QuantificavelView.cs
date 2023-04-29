using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class QuantificavelView : Enums<char?>
    {
        [DataMember]
        public static readonly QuantificavelView Sim = new QuantificavelView('S', "Sim");
        [DataMember]
        public static readonly QuantificavelView Nao = new QuantificavelView('N', "Não");
        public QuantificavelView(char? key, string displayName) : base(key, displayName) { }
    }

}

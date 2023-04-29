
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class ObrigaAreaView : Enums<char?>
    {
        [DataMember]
        public static readonly ObrigaAreaView Sim = new ObrigaAreaView('S', "Sim");
        [DataMember]
        public static readonly ObrigaAreaView nao = new ObrigaAreaView('N', "Não");
        public ObrigaAreaView(char? key, string displayName) : base(key, displayName) { }
    }

}

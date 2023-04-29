
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class ObrigaCustoView : Enums<char?>
    {
        [DataMember]
        public static readonly ObrigaCustoView Sim = new ObrigaCustoView('S', "Sim");
        [DataMember]
        public static readonly ObrigaCustoView nao = new ObrigaCustoView('N', "Não");
        public ObrigaCustoView(char? key, string displayName) : base(key, displayName) { }
    }

}

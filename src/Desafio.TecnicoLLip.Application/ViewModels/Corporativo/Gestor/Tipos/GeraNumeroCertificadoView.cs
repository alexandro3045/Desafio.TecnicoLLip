using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class GeraNumeroCertificadoView : Enums<char?>
    {
        [DataMember]
        public static readonly GeraNumeroCertificadoView Sim = new GeraNumeroCertificadoView('S', "Sim");
        [DataMember]
        public static readonly GeraNumeroCertificadoView nao = new GeraNumeroCertificadoView('N', "Não");
        public GeraNumeroCertificadoView(char? key, string displayName) : base(key, displayName) { }
    }

}

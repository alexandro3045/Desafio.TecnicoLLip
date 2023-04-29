using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class DivulgadoView : Enums<char?>
    {
        [DataMember]
        public static readonly DivulgadoView Sim = new DivulgadoView('S', "Sim");
        [DataMember]
        public static readonly DivulgadoView Nao = new DivulgadoView('N', "Não");
        public DivulgadoView(char? key, string displayName) : base(key, displayName) { }
    }

}

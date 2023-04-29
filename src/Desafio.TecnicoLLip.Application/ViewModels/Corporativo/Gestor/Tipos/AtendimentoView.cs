using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class AtendimentoView : Enums<char>
    {
        [DataMember]
        public static readonly AtendimentoView Sim = new AtendimentoView('S', "Sim");
        [DataMember]
        public static readonly AtendimentoView Nao = new AtendimentoView('N', "Não");
        public AtendimentoView(char key, string displayName) : base(key, displayName) { }
    }

}

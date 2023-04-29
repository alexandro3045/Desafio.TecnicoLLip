using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class ExameView : Enums<char?>
    {
        [DataMember]
        public static readonly ExameView Sim = new ExameView('S', "Sim");
        [DataMember]
        public static readonly ExameView Nao = new ExameView('N', "Não");
        public ExameView(char? key, string displayName) : base(key, displayName) { }
    }
}

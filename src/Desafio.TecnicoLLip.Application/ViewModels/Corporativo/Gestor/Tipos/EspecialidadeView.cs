using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class EspecialidadeView : Enums<char?>
    {
        [DataMember]
        public static readonly EspecialidadeView Sim = new EspecialidadeView('S', "Sim");
        [DataMember]
        public static readonly EspecialidadeView Nao = new EspecialidadeView('N', "Não");
        public EspecialidadeView(char? key, string displayName) : base(key, displayName) { }
    }
}

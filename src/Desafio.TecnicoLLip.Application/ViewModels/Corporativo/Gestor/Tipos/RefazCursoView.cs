using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class RefazCursoView : Enums<char?>
    {
        [DataMember]
        public static readonly RefazCursoView Sim = new RefazCursoView('S', "Sim");
        [DataMember]
        public static readonly RefazCursoView nao = new RefazCursoView('N', "Não");
        public RefazCursoView(char? key, string displayName) : base(key, displayName) { }
    }

}

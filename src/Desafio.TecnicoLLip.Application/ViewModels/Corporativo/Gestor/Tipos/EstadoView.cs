using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    [DataContract]
    public class EstadoView : Enums<char?>
    {
        [DataMember]
        public static readonly EstadoView Estudo = new EstadoView('E', "Estudo");
        [DataMember]
        public static readonly EstadoView Aprovado = new EstadoView('A', "Aprovado");
        [DataMember]
        public static readonly EstadoView NaoAprovado = new EstadoView('N', "Não Aprovado");
        public EstadoView(char? key, string displayName) : base(key, displayName) { }
    }
}

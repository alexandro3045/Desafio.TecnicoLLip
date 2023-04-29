using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoEntidadeView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoEntidadeView Llip = new TipoEntidadeView('1', "Llip");
        [DataMember]
        public static readonly TipoEntidadeView Sesi = new TipoEntidadeView('2', "Sesi");
        [DataMember]
        public static readonly TipoEntidadeView Senai = new TipoEntidadeView('3', "Senai");
        public TipoEntidadeView(char? key, string displayName) : base(key, displayName) { }
    }
}

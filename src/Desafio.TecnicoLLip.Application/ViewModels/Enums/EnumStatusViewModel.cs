#region Includes  
using System.Runtime.Serialization;
using Desafio.TecnicoLLip.Domain.Models.Utility;
#endregion

namespace Desafio.TecnicoLLip.Application.ViewModels.Enums
{
    [DataContract]
    public class EnumStatusViewModel : Enums<char?>
    {
        [DataMember]
        public static readonly EnumStatusViewModel Pendente = new EnumStatusViewModel('P', "Pendente");
        [DataMember]
        public static readonly EnumStatusViewModel Andamento = new EnumStatusViewModel('A', "Andamento");
        [DataMember]
        public static readonly EnumStatusViewModel Concluida = new EnumStatusViewModel('C', "Concuida");
        
        public EnumStatusViewModel(char? key, string displayName) : base(key, displayName) { }
    }
}
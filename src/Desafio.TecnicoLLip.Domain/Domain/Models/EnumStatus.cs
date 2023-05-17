#region Includes  
using System.Runtime.Serialization;
using Desafio.TecnicoLLip.Domain.Models.Utility;
#endregion

namespace Desafio.TecnicoLLip.Domain.Models
{
    public class EnumStatus : Enums<char?>
    {
        public static readonly EnumStatus Pendente = new EnumStatus('P', "Pendente");
        public static readonly EnumStatus Andamento = new EnumStatus('A', "Andamento");
        public static readonly EnumStatus Concluida = new EnumStatus('C', "Concuida");
     
        public EnumStatus(char? key, string displayName) : base(key, displayName) { }
    }
}
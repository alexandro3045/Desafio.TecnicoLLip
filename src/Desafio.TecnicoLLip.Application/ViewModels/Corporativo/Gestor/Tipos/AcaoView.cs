using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class AcaoView : Enums<char?>
    {
        [DataMember]
        public static readonly AcaoView Direta = new AcaoView('D', "Direta");
        [DataMember]
        public static readonly AcaoView Indireta = new AcaoView('I', "Indireta");
        public AcaoView(char? key, string name) : base(key, name) { }
    }
}

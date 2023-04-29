using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos.Base
{
    [DataContract]
    [KnownType(typeof(CustoSistemaView))]
    public class FlagView : Enums<char?>
    {
        [DataMember]
        public static readonly FlagView Sim = new FlagView('S', "Sim");
        [DataMember]
        public static readonly FlagView nao = new FlagView('N', "Não");
        public FlagView(char? key, string name) : base(key, name) { }
    }
}

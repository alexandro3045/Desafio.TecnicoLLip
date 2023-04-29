using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos.Base;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    [KnownType(typeof(FlagView))]
    public class CustoSistemaView : Enums<char?>
    {
        [DataMember]
        public static readonly CustoSistemaView Sim = new CustoSistemaView('S', "Sim");
        [DataMember]
        public static readonly CustoSistemaView nao = new CustoSistemaView('N', "Não");
        public CustoSistemaView(char? key, string displayName) : base(key, displayName) { }
    }
}

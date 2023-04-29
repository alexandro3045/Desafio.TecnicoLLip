
using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto RiscoViewModel"/>
    ///</summary>
    [DataContract]
    public class RiscoViewModel : TipoViewModel<string>
    {
        [DataMember]
        public string TipoRiscoId { get; set; }
        [DataMember]
        public TipoRiscoViewModel TipoRisco { get; set; }
    }
}

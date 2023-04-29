using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto Area"/>
    ///</summary>
    [DataContract]
    public class AgenteViewModel : TipoViewModel<string>
    {
        [DataMember]
        public ProdutoViewModel Produto { get; set; }
        [DataMember]
        public string RiscoId { get; set; }
        [DataMember]
        public RiscoViewModel Risco { get; set; }
    }
}

using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.SRC
{
    ///<summary>
    ///Objeto Entidade"/>
    ///</summary>
    [DataContract]
    public class EntidadeViewModel : TipoViewModel<int>
    {
        [DataMember]
        public string TipoEntidadeVinculoId { get; set; }

        [DataMember]
        public TipoEntidadeVinculoViewModel TipoEntidadeVinculo { get; set; }
    }
}
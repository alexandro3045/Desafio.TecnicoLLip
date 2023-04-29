using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto Tipo Unidade Negocio"/>
    ///</summary>
    [DataContract]
    public class TipoUnidadeNegocioTipoEntidadeVinculoViewModel : BaseViewModel<short>
    {
        ///<summary>
        ///Id do Tipo Unidade Negocio
        ///</summary>
        [DataMember]
        public Int16 TipoUnidadeNegocioId { get; set; }
        ///<summary>
        ///Tipo Unidade Negocio
        ///</summary>
        [DataMember]
        public TipoUnidadeNegocioViewModel TipoUnidadeNegocio { get; set; }
        ///<summary>
        ///Id do Tipo Entidade Vinculo
        ///</summary>
        [DataMember]
        public string TipoEntidadeVinculoId { get; set; }
        ///<summary>
        ///Tipo Entidade Vinculo
        ///</summary>
        [DataMember]
        public TipoEntidadeVinculoViewModel TipoEntidadeVinculo { get; set; }
    }
}
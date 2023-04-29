using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Protheus
{
    public class BaseProtheusViewModel<T> : TipoViewModel<T>
    {
        ///<summary>
        ///Data início
        ///</summary>
        [DataMember]
        public DateTime? Inicio { get; set; }
        ///<summary>
        ///Data fim
        ///</summary>
        [DataMember]
        public DateTime? Fim { get; set; }
        ///<summary>
        ///Empresa
        ///</summary>
        [DataMember]
        public string Empresa { get; set; }
    }

}

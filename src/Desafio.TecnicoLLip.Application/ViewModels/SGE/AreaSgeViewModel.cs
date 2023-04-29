using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.SGE
{
    public class AreaSgeViewModel : TipoViewModel<Int16>
    {
        ///<summary>
        ///Código coligada.
        ///</summary>
        [DataMember]
        public Int16 ColigadaId { get; set; }
        ///<summary>
        ///Objeto coligada
        ///</summary>
        [DataMember]
        public ColigadaViewModel Coligada { get; set; }
    }
}
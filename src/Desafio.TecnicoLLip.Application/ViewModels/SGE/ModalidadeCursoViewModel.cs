using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.SGE;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.SGE
{
    public class ModalidadeCursoViewModel : TipoViewModel<string>
    {
        ///<summary>
        ///Código coligada.
        ///</summary>
        [DataMember]
        public Int16 ColigadaId { get; set; }
        ///<summary>
        ///Objecto coligada.
        ///</summary>
        [DataMember]
        public Coligada Coligada { get; set; }
    }
}
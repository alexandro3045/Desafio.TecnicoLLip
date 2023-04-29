using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    [DataContract]
    public class ModalidadeViewModel : TipoViewModel<Int16?>
    {
        [DataMember]
        public TipoEntidade TipoEntidade { get; set; }
        [DataMember]
        public DateTime Fim { get; set; }
    }
}

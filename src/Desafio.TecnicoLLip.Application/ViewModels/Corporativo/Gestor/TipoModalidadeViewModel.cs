using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    [DataContract]
    public class TipoModalidadeViewModel : TipoViewModel<int>
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string CodigoDN { get; set; }
        [DataMember]
        public Int16 ModalidadeId { get; set; }
        [DataMember]
        public ModalidadeViewModel Modalidade { get; set; }
        [DataMember]
        public Acao Acao { get; set; }
    }
}

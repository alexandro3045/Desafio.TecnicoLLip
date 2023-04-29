using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.SRC
{
    [DataContract]
    public class RegiaoViewModel : TipoViewModel<int>
    {
        [DataMember]
        public short? TipoRegiaoId { get; set; }
        [DataMember]
        public TipoRegiaoViewModel TipoRegiao { get; set; }
        [DataMember]
        public int? EnderecoUnidadeId { get; set; }
        [DataMember]
        public EnderecoUnidadeViewModel EnderecoUnidade { get; set; }
    }
}
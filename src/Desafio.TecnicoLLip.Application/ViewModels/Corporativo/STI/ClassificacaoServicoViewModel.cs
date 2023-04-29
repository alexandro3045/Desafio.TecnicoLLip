using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.STI
{
    ///<summary>
    ///Objeto Area"/>
    ///</summary>
    [DataContract]
    public class ClassificacaoServicoViewModel : TipoViewModel<int>
    {
        [DataMember]
        public int LinhaServicoId { get; set; }
        [DataMember]
        public LinhaServicoViewModel LinhaServico { get; set; }
        [DataMember]
        public string AreaDN { get; set; }
    }
}
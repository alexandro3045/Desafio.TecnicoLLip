using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    ///<summary>
    ///Objeto ServicoViewModel"/>
    ///</summary>
    [DataContract]
    public class NivelServicoViewlModel : TipoViewModel<int?>
    {
        [DataMember]
        public Int16? TabelaServicoId { get; set; }
        [DataMember]
        public TabelaServicoViewModel TabelaServico { get; set; }
    }
}

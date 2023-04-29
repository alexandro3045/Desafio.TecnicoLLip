using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;


namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto ServicoViewModel"/>
    ///</summary>
    [DataContract]
    public class TabelaServicoViewModel : TipoViewModel<Int16?>
    {
        [DataMember]
        public string CodigoTipoEntidadeVinculo { get; set; }
        [DataMember]
        public TipoEntidadeVinculoViewModel TipoEntidadeVinculo { get; set; }
        [DataMember]
        public char? IsAtendimento { get; set; }
        [DataMember]
        public char TipoPreco { get; set; }
    }
}

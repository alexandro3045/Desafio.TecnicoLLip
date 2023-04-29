using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto TabelaServicoTipoEntidadeVinculoViewModel"/>
    ///</summary>
    [DataContract]
    public class TabelaServicoTipoEntidadeVinculoViewModel : TipoViewModel<Int16>
    {
        [DataMember]
        public char? CodigoTipoServico { get; set; }
        [DataMember]
        public TipoServicoViewModel TipoServico { get; set; }
        [DataMember]
        public int? ProdutoId { get; set; }
        [DataMember]
        public ProdutoViewModel Produto { get; set; }
        [DataMember]
        public int? GrupoClassificacaoId { get; set; }
        [DataMember]
        public GrupoClassificacaoViewModel GrupoClassificacao { get; set; }
        [DataMember]
        public int? GrupoClassificacaoPaiId { get; set; }
        //<summary>
        //Objeto Grupo do Produto
        //</summary
        [DataMember]
        public GrupoClassificacaoViewModel GrupoClassificacaoPai { get; set; }
    }
}

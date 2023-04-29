using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto ItemContabilProdutoViewModel"/>
    ///</summary>
    [DataContract]
    public class ClasseValorProdutoViewModel : TipoViewModel<string>
    {
        ///<summary>
        ///Codigo empresa
        ///</summary>
        [DataMember]
        public string CodigoEmpresa { get; set; }
        ///<summary>
        ///CodigoCentroResponsabilidade
        ///</summary>
        [DataMember]
        public string CodigoCentroResponsabilidade { get; set; }
        ///<summary>
        ///Id do Produto
        ///</summary>
        [DataMember]
        public int? ProdutoId { get; set; }
        ///<summary>
        ///Data inicio vigencia
        ///</summary>
        [DataMember]
        public DateTime Inicio { get; set; }
        ///<summary>
        ///Data fim vigencia
        ///</summary>
        [DataMember]
        public DateTime? Fim { get; set; }
        ///<summary>
        ///Classificação do grupo
        ///</summary>
        [DataMember]
        public int? GrupoClassifId { get; set; }
    }

}
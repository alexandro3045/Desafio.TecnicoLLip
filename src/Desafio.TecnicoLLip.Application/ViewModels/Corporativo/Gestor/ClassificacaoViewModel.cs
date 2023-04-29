using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto ClassificacaoViewModel"/>
    ///</summary>
    [DataContract]
    public class ClassificacaoViewModel : Base.Base
    {
        public int GrupoProdutoId { get; set; }
        public GrupoClassificacaoViewModel GrupoClassificacao { get; set; }
        public int? ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }
        public char FlagDivulgado { get; set; }
        public Divulgado Divulgado { get; set; }
        public bool? NovaInterface { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}

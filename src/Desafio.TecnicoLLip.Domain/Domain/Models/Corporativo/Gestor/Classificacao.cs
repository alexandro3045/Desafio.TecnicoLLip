using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Classificacao : Base.Base
    {
        public int GrupoClassificacaoId { get; set; }
        public GrupoClassificacao GrupoClassificacao { get; set; }
        public int? ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public Divulgado Divulgado { get; set; }
        public bool? NovaInterface { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}

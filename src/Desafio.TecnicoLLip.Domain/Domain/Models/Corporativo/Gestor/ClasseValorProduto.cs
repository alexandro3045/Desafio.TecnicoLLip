using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class ClasseValorProduto : Base.Base
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoCentroResponsabilidade { get; set; }
        public int? ProdutoId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public int? GrupoClassifId { get; set; }
    }
}

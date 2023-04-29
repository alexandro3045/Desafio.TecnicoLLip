using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Saude
{
    public class ProdutoTipoFicha : Base.Base
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
        public int TipoFichaId { get; set; }
        public TipoFicha TipoFicha { get; set; }
        public Flag GeraAtendimento { get; set; }
    }
}
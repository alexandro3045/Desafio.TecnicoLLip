using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC
{
    public class Regiao : TipoModel<int>
    {
        public short? TipoRegiaoId { get; set; }
        public TipoRegiao TipoRegiao { get; set; }
        public int? EnderecoUnidadeId { get; set; }
        public EnderecoUnidade EnderecoUnidade { get; set; }
    }
}
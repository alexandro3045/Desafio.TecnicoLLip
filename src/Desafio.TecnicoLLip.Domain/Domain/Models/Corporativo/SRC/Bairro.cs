using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC
{
    public class Bairro : TipoModel<int>
    {
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
        public string CodigoLocalCorreio { get; set; }
        public string CodigoBairroCorreio { get; set; }
        public char? Ativo { get; set; }
        public string DescricaoAbreviada { get; set; }
    }
}

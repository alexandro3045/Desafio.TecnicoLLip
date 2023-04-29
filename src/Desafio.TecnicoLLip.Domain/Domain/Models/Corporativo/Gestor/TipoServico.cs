using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TipoServico : TipoModel<char?>
    {
        public string Sigla { get; set; }
        public ObrigaArea ObrigaArea { get; set; }
        public ObrigaCusto ObrigaCusto { get; set; }
    }
}

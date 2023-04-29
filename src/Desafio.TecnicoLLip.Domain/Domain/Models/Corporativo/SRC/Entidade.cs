using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC
{
    public class Entidade : TipoModel<int>
    {
        public string TipoEntidadeVinculoId { get; set; }

        public TipoEntidadeVinculo TipoEntidadeVinculo { get; set; }
    }
}

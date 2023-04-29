using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TipoUnidadeNegocioTipoEntidadeVinculo : BaseModel<short>
    {
        public short TipoUnidadeNegocioId { get; set; }
        public TipoUnidadeNegocio TipoUnidadeNegocio { get; set; }
        public string TipoEntidadeVinculoId { get; set; }
        public TipoEntidadeVinculo TipoEntidadeVinculo { get; set; }
    }
}

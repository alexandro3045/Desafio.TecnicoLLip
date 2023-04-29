using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Lazer : TipoModel<int>
    {
        public Produto Produto { get; set; }
        public TipoLazer TipoLazer { get; set; }
        public FamiliaLazer FamiliaLazer { get; set; }
    }
}

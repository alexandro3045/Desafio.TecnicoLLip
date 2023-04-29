using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoResultado : Enums<decimal>
    {
        public readonly static TipoResultado MeioAmbiente = new TipoResultado(1, "Limites");
        public readonly static TipoResultado AssistenciaSocial = new TipoResultado(2, "Positivo / Negativo");
        public TipoResultado(decimal key, string displayName) : base(key, displayName) { }
    }
}

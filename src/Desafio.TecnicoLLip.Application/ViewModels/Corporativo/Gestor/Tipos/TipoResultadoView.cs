using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoResultadoView : Enums<decimal>
    {
        [DataMember]
        public static readonly TipoResultadoView MeioAmbiente = new TipoResultadoView(1, "Limites");
        [DataMember]
        public static readonly TipoResultadoView AssistenciaSocial = new TipoResultadoView(2, "Positivo / Negativo");
        public TipoResultadoView(decimal key, string displayName) : base(key, displayName) { }
    }
}

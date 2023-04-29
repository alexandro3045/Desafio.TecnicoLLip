using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoServicoSaudeView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoServicoSaudeView MeioAmbiente = new TipoServicoSaudeView('P', "Procedimento");
        [DataMember]
        public static readonly TipoServicoSaudeView AssistenciaSocial = new TipoServicoSaudeView('C', "Consulta");
        [DataMember]
        public static readonly TipoServicoSaudeView Educacao = new TipoServicoSaudeView('N', "Nenhum");
        public TipoServicoSaudeView(char? key, string displayName) : base(key, displayName) { }
    }
}

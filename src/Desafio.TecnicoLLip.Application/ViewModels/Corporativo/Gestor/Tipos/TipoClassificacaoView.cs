using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoClassificacaoView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoClassificacaoView MeioAmbiente = new TipoClassificacaoView('M', "Médico");
        [DataMember]
        public static readonly TipoClassificacaoView AssistenciaSocial = new TipoClassificacaoView('O', "Odontológico");
        [DataMember]
        public static readonly TipoClassificacaoView Educacao = new TipoClassificacaoView('E', "Educação em Saúde");
        [DataMember]
        public static readonly TipoClassificacaoView Tecnologico = new TipoClassificacaoView('S', "Saúde Ocupacional");
        [DataMember]
        public static readonly TipoClassificacaoView Cultura = new TipoClassificacaoView('T', "Segurança do Trabalho");
        public TipoClassificacaoView(char? key, string displayName) : base(key, displayName) { }
    }
}

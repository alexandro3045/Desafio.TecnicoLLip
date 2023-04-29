using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoClassificacao : Enums<char?>
    {
        public static readonly TipoClassificacao MeioAmbiente = new TipoClassificacao('M', "Médico");
        public static readonly TipoClassificacao AssistenciaSocial = new TipoClassificacao('O', "Odontológico");
        public static readonly TipoClassificacao Educacao = new TipoClassificacao('E', "Educação em Saúde");
        public static readonly TipoClassificacao Tecnologico = new TipoClassificacao('S', "Saúde Ocupacional");
        public static readonly TipoClassificacao Cultura = new TipoClassificacao('T', "Segurança do Trabalho");
        public TipoClassificacao(char? key, string displayName) : base(key, displayName) { }
    }
}

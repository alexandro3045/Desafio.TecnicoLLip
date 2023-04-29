using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{

    public class TipoProcedimento : Enums<char?>
    {
        public static readonly TipoProcedimento MeioAmbiente = new TipoProcedimento('D', "Diagnóstico");
        public static readonly TipoProcedimento AssistenciaSocial = new TipoProcedimento('C', "Cirúrgicos");
        public static readonly TipoProcedimento Educacao = new TipoProcedimento('T', "Terapia");
        public static readonly TipoProcedimento MudancaFuncao = new TipoProcedimento('O', "Complementar");
        public static readonly TipoProcedimento Nenhum = new TipoProcedimento('N', "Nenhum");
        public TipoProcedimento(char? key, string displayName) : base(key, displayName) { }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoOrigemServico : Enums<char?>
    {
        public static readonly  TipoOrigemServico MeioAmbiente = new TipoOrigemServico('1', "Admissional");
        public static readonly  TipoOrigemServico AssistenciaSocial = new TipoOrigemServico('2', "Periódico");
        public static readonly  TipoOrigemServico Educacao = new TipoOrigemServico('3', "Retorno ao trabalho");
        public static readonly  TipoOrigemServico MudancaFuncao = new TipoOrigemServico('4', "Mudança de Função");
        public static readonly  TipoOrigemServico Demissional = new TipoOrigemServico('5', "Demissional");
        public TipoOrigemServico(char? key, string displayName) : base(key, displayName) { }
    }
}

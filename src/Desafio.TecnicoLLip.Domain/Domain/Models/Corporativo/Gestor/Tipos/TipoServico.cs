using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoServico : Enums<char?>
    {
        public static readonly  TipoServico EducacaoExecutiva = new TipoServico('A', "EDUCAÇÃO EXECUTIVA");
        public static readonly  TipoServico MeioAmbiente = new TipoServico('B', "Meio Ambiente");
        public static readonly  TipoServico AssistenciaSocial = new TipoServico('C', "Assistência Social");
        public static readonly  TipoServico ServicosIEL = new TipoServico('D', "Serviços Intitucionais IEL");
        public static readonly  TipoServico Educacao = new TipoServico('E', "Educação");
        public static readonly  TipoServico AtendimentoSetorial = new TipoServico('F', "Atendimento Setorial");
        public static readonly  TipoServico ProgramaEstagio = new TipoServico('G', "Programa de Estágio");
        public static readonly  TipoServico SegurancaTrabalho = new TipoServico('H', "Segurança do Trabalho");
        public static readonly  TipoServico Diversos = new TipoServico('I', "Diversos - Reneg");
        public static readonly  TipoServico CIRJ = new TipoServico('J', "Serviços Intitucionais CIRJ");
        public static readonly  TipoServico Llip = new TipoServico('K', "Casa Llip");
        public static readonly  TipoServico EsporteLazer = new TipoServico('L', "Esporte e Lazer");
        public static readonly  TipoServico Administracao = new TipoServico('M', "Administração");
        public static readonly  TipoServico Alimentacao = new TipoServico('N', "Alimentação");
        public static readonly  TipoServico GestaoEmpresarial = new TipoServico('O', "Gestão Empresarial");
        public static readonly  TipoServico ResponsabilidadeSocial = new TipoServico('R', "Responsabilidade Social Corporativa");
        public static readonly  TipoServico Saude = new TipoServico('S', "Saúde");
        public static readonly  TipoServico Tecnologico = new TipoServico('T', "Servico Tecnológico");
        public static readonly  TipoServico Cultura = new TipoServico('U', "Cultura");
        public static readonly  TipoServico DemandasEmpresariais = new TipoServico('V', "Demandas Empresariais");
        public static readonly  TipoServico Convenio = new TipoServico('W', "Convênio");
        public static readonly  TipoServico ComercioExterior = new TipoServico('X', "Comércio Exterior");
        public TipoServico(char? key, string displayName) : base(key, displayName) { }
    }
}

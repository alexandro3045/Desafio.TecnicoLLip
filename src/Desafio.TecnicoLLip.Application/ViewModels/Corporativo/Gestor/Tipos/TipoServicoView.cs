using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    public class TipoServicoView : Enums<char?>
    {
        public readonly static TipoServicoView MeioAmbiente = new TipoServicoView('B', "Meio Ambiente");
        public readonly static TipoServicoView AssistenciaSocial = new TipoServicoView('C', "Assistência Social");
        public readonly static TipoServicoView Educacao = new TipoServicoView('E', "Educação");
        public readonly static TipoServicoView Lazer = new TipoServicoView('L', "Lazer");
        public readonly static TipoServicoView Administracao = new TipoServicoView('M', "Administração");
        public readonly static TipoServicoView Alimentacao = new TipoServicoView('N', "Alimentação");
        public readonly static TipoServicoView Saude = new TipoServicoView('S', "Saúde");
        public readonly static TipoServicoView Tecnologico = new TipoServicoView('T', "Servico Tecnológico");
        public readonly static TipoServicoView Cultura = new TipoServicoView('U', "Cultura");
        public TipoServicoView(char? key, string displayName) : base(key, displayName) { }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoOrigemServicoView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoOrigemServicoView MeioAmbiente = new TipoOrigemServicoView('1', "Admissional");
        [DataMember]
        public static readonly TipoOrigemServicoView AssistenciaSocial = new TipoOrigemServicoView('2', "Periódico");
        [DataMember]
        public static readonly TipoOrigemServicoView Educacao = new TipoOrigemServicoView('3', "Retorno ao trabalho");
        [DataMember]
        public static readonly TipoOrigemServicoView MudancaFuncao = new TipoOrigemServicoView('4', "Mudança de Função");
        [DataMember]
        public static readonly TipoOrigemServicoView Demissional = new TipoOrigemServicoView('5', "Demissional");
        public TipoOrigemServicoView(char? key, string displayName) : base(key, displayName) { }
    }
}

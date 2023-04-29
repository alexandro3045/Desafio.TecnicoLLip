using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoProcedimentoView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoProcedimentoView MeioAmbiente = new TipoProcedimentoView('D', "Diagnóstico");
        [DataMember]
        public static readonly TipoProcedimentoView AssistenciaSocial = new TipoProcedimentoView('C', "Cirúrgicos");
        [DataMember]
        public static readonly TipoProcedimentoView Educacao = new TipoProcedimentoView('T', "Terapia");
        [DataMember]
        public static readonly TipoProcedimentoView MudancaFuncao = new TipoProcedimentoView('O', "Complementar");
        [DataMember]
        public static readonly TipoProcedimentoView Nenhum = new TipoProcedimentoView('N', "Nenhum");
        public TipoProcedimentoView(char? key, string displayName) : base(key, displayName) { }
    }
}

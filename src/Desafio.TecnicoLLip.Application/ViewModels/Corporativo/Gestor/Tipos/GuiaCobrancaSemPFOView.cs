using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    [DataContract]
    public class GuiaCobrancaSemPfoView : Enums<char?>
    {
        [DataMember]
        public readonly static GuiaCobrancaSemPfoView Sim = new GuiaCobrancaSemPfoView('S', "Sim");
        [DataMember]
        public readonly static GuiaCobrancaSemPfoView Nao = new GuiaCobrancaSemPfoView('N', "Não");
        public GuiaCobrancaSemPfoView(char? key, string displayName) : base(key, displayName) { }
    }
}

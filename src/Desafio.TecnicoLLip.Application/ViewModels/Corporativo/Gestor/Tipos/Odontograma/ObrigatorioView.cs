using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos.Odontograma
{
    [DataContract]
    public class ObrigatorioView : Enums<char?>
    {
        [DataMember]
        public static readonly ObrigatorioView Sim = new ObrigatorioView('S', "Sim");
        [DataMember]
        public static readonly ObrigatorioView Nao = new ObrigatorioView('N', "Não");

        public ObrigatorioView(char? key, string displayName) : base(key, displayName) { }
    }
}

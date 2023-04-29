using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class ValeCulturaView : Enums<char?>
    {
        [DataMember]
        public static readonly ValeCulturaView Sim = new ValeCulturaView('S', "Sim");
        [DataMember]
        public static readonly ValeCulturaView Nao = new ValeCulturaView('N', "Não");
        public ValeCulturaView(char? key, string displayName) : base(key, displayName) { }
    }

}

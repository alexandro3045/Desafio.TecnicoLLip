
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class UnidadeVinculadaView : Enums<char?>
    {
        [DataMember]
        public static readonly UnidadeVinculadaView Sim = new UnidadeVinculadaView('S', "Sim");
        [DataMember]
        public static readonly UnidadeVinculadaView Nao = new UnidadeVinculadaView('N', "Não");
        public UnidadeVinculadaView(char? key, string displayName) : base(key, displayName) { }
    }

}

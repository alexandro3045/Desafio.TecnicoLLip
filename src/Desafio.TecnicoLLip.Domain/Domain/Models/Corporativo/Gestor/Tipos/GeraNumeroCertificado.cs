
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class GeraNumeroCertificado : Enums<char?>
    {
        public static readonly  GeraNumeroCertificado Sim = new GeraNumeroCertificado('S', "Sim");
        public static readonly  GeraNumeroCertificado Nao = new GeraNumeroCertificado('N', "Não");
        public GeraNumeroCertificado(char? key, string displayName) : base(key, displayName) { }
    }
}

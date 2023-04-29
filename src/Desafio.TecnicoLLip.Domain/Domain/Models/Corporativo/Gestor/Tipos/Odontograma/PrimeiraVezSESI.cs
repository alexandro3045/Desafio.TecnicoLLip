using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class PrimeiraVezSesi: Enums<char?>
    {
        public static readonly  PrimeiraVezSesi Sim = new PrimeiraVezSesi('S', "Sim");
        public static readonly  PrimeiraVezSesi Nao = new PrimeiraVezSesi('N', "Não");
        public PrimeiraVezSesi(char? key, string name) : base(key, name) { }
    }
}

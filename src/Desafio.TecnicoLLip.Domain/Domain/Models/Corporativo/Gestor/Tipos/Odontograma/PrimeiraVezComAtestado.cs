using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class PrimeiraVezComAtestado : Enums<char?>
    {
        public static readonly  PrimeiraVezComAtestado Sim = new PrimeiraVezComAtestado('S', "Sim");
        public static readonly  PrimeiraVezComAtestado Nao = new PrimeiraVezComAtestado('N', "Não");
        public PrimeiraVezComAtestado(char? key, string name) : base(key, name) { }
    }
}

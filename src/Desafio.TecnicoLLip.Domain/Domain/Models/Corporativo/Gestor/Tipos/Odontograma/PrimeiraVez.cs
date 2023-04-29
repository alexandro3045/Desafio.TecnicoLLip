using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class PrimeiraVez : Enums<char?>
    {
        public static readonly  PrimeiraVez Sim = new PrimeiraVez('S', "Sim");
        public static readonly  PrimeiraVez Nao = new PrimeiraVez('N', "Não");
        public PrimeiraVez(char? key, string name) : base(key, name) { }
    }
}

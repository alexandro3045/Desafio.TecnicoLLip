using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TodasPessoas : Enums<char?>
    {
        public static readonly  TodasPessoas Sim = new TodasPessoas('S', "Sim");
        public static readonly  TodasPessoas Nao = new TodasPessoas('N', "Não");
        public TodasPessoas(char? key, string displayName) : base(key, displayName) { }
    }
}

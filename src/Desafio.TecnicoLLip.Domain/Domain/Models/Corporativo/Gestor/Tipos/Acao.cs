using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Acao : Enums<char?>
    {
        public static readonly  Acao Direta = new Acao('D', "Direta");
        public static readonly  Acao Indireta = new Acao('I', "Indireta");
        public Acao(char? key, string Name) : base(key, Name) { }
    }
}

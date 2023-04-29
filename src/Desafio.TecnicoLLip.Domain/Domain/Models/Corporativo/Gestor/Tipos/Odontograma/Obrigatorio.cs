using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Odontograma
{
    public class Obrigatorio : Enums<char?>
    {
        public static readonly  Obrigatorio Sim = new Obrigatorio('S', "Sim");
        public static readonly  Obrigatorio Nao = new Obrigatorio('N', "Não");
        public Obrigatorio(char? key, string displayName) : base(key, displayName) { }
    }
}

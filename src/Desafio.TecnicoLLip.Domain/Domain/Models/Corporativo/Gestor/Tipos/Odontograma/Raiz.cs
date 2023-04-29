using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Odontograma
{
    public class Raiz : Enums<char?>
    {
        public static readonly  Raiz Sim = new Raiz('S', "Sim");
        public static readonly  Raiz Nao = new Raiz('N', "Não");
        public Raiz(char? key, string name) : base(key, name) { }
    }
}

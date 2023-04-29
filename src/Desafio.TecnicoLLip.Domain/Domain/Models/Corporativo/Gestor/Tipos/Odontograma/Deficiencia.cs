using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Odontograma
{
    public class Deficiencia : Enums<char?>
    {
        public static readonly  Deficiencia Sim = new Deficiencia('S', "Sim");
        public static readonly  Deficiencia Nao = new Deficiencia('N', "Não");
        public Deficiencia(char? key, string displayName) : base(key, displayName) { }
    }
}

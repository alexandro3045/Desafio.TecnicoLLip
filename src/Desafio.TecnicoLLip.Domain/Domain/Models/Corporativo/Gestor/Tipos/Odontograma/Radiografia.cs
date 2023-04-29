using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Odontograma
{
    public class Radiografia : Enums<char?>
    {
        public static readonly  Radiografia Sim = new Radiografia('S', "Sim");
        public static readonly  Radiografia Nao = new Radiografia('N', "Não");
        public Radiografia(char? key, string displayName) : base(key, displayName) { }
    }
}


using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class RefazCurso : Enums<char?>
    {
        public static readonly  RefazCurso Sim = new RefazCurso('S', "Sim");
        public static readonly  RefazCurso Nao = new RefazCurso('N', "Não");
        public RefazCurso(char? key, string displayName) : base(key, displayName) { }
    }

}


using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Divulgado : Enums<char?>
    {
        public static readonly  Divulgado Sim = new Divulgado('S', "Sim");
        public static readonly  Divulgado Nao = new Divulgado('N', "Não");
        public Divulgado(char? key, string displayName) : base(key, displayName) { }
    }

}

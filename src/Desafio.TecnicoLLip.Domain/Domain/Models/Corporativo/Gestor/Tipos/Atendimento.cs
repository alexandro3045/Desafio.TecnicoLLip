
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Atendimento : Enums<char>
    {
        public static readonly  Atendimento Sim = new Atendimento('S', "Sim");
        public static readonly  Atendimento Nao = new Atendimento('N', "Não");
        public Atendimento(char key, string displayName) : base(key, displayName) { }
    }
}

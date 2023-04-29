using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Especialidade : Enums<char?>
    {
        public static readonly  Especialidade Sim = new Especialidade('S', "Sim");
        public static readonly  Especialidade Nao = new Especialidade('N', "Não");
        public Especialidade(char? key, string displayName) : base(key, displayName) { }
    }
}

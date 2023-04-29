using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class ContemDisciplina : Enums<char?>
    {
        public static readonly  ContemDisciplina Sim = new ContemDisciplina('S', "Sim");
        public static readonly  ContemDisciplina Nao = new ContemDisciplina('N', "Não");
        public ContemDisciplina(char? key, string displayName) : base(key, displayName) { }
    }
}

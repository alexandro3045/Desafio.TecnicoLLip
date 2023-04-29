using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TodosServicos : Enums<char?>
    {
        public static readonly  TodosServicos Sim = new TodosServicos('S', "Sim");
        public static readonly  TodosServicos Nao = new TodosServicos('N', "Não");
        public TodosServicos(char? key, string displayName) : base(key, displayName) { }
    }
}

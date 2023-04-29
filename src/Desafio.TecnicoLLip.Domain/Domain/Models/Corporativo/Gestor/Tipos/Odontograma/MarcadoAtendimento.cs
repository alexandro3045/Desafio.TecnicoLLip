using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class MarcadoAtendimento : Enums<char?>
    {
        public static readonly  MarcadoAtendimento Sim = new MarcadoAtendimento('S', "Sim");
        public static readonly  MarcadoAtendimento Nao = new MarcadoAtendimento('N', "Não");
        public MarcadoAtendimento(char? key, string name) : base(key, name) { }
    }
}

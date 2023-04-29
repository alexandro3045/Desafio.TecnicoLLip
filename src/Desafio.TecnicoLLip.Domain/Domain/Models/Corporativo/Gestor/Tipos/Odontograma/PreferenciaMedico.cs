using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class PreferenciaMedico : Enums<char?>
    {
        public static readonly  PreferenciaMedico Sim = new PreferenciaMedico('S', "Sim");
        public static readonly  PreferenciaMedico Nao = new PreferenciaMedico('N', "Não");
        public PreferenciaMedico(char? key, string name) : base(key, name) { }
    }
}

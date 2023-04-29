using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TodasUnidadesNegocios : Enums<char?>
    {
        public static readonly  TodasUnidadesNegocios Sim = new TodasUnidadesNegocios('S', "Sim");
        public static readonly  TodasUnidadesNegocios Nao = new TodasUnidadesNegocios('N', "Não");
        public TodasUnidadesNegocios(char? key, string displayName) : base(key, displayName) { }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoConsulta : Enums<char?>
    {
        public static readonly  TipoConsulta Consulta = new TipoConsulta('C', "Consulta");
        public static readonly  TipoConsulta Reconsulta = new TipoConsulta('R', "Reconsulta");
        public TipoConsulta(char? key, string name) : base(key, name) { }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Instrucao : TipoModel<char>
    {
        public char Codigo { get; set; }
    }
}

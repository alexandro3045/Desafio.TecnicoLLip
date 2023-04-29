using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoCni : Enums<char?>
    {
        public static readonly  TipoCni Identificado = new TipoCni('1', "Contratante");
        public static readonly  TipoCni Planejado = new TipoCni('2', "Contratado");
        public TipoCni(char? key, string name) : base(key, name) { }
    }
}

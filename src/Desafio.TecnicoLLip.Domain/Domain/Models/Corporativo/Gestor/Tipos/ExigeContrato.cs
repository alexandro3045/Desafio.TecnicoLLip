using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class ExigeContrato : Enums<char?>
    {
        public static readonly  ExigeContrato Ambos = new ExigeContrato('A', "Ambos");
        public static readonly  ExigeContrato Fisica = new ExigeContrato('F', "Fisica");
        public static readonly  ExigeContrato Jurídica = new ExigeContrato('J', "Jurídica");
        public static readonly  ExigeContrato Nenhum = new ExigeContrato('N', "Nenhum");
        public ExigeContrato(char? key, string displayName) : base(key, displayName) { }
    }
}

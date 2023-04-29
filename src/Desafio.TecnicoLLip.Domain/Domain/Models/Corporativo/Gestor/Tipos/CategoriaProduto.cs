using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Categoria : Enums<char?>
    {
        public static readonly  Categoria Material = new Categoria('M', "Material");
        public static readonly  Categoria Pacote = new Categoria('P', "Pacote");
        public static readonly  Categoria Servicos = new Categoria('S', "Servicos");
        public Categoria(char? key, string displayName) : base(key, displayName) { }
    }
}

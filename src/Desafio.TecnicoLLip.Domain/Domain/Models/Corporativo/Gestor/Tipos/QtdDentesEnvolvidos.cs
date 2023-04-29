using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class QtdDentesEnvolvidos : Enums<byte>
    {
        public static readonly  QtdDentesEnvolvidos Nenhum = new QtdDentesEnvolvidos(0, "Nenhum");
        public static readonly  QtdDentesEnvolvidos Um = new QtdDentesEnvolvidos(1, "Um dente");
        public static readonly  QtdDentesEnvolvidos MaisDeUm = new QtdDentesEnvolvidos(2, "Mais de Um");
        public static readonly  QtdDentesEnvolvidos NenhumEspecifico = new QtdDentesEnvolvidos(3, "Nenhum Específico");
        public QtdDentesEnvolvidos(byte key, string displayName) : base(key, displayName) { }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class CategoriaProdutoView : Enums<char?>
    {
        [DataMember]
        public static readonly CategoriaProdutoView Material = new CategoriaProdutoView('M', "Material");
        [DataMember]
        public static readonly CategoriaProdutoView Pacote = new CategoriaProdutoView('P', "Pacote");
        [DataMember]
        public static readonly CategoriaProdutoView Servicos = new CategoriaProdutoView('S', "Servicos");

        public CategoriaProdutoView(char? key, string name) : base(key, name) { }
    }
}

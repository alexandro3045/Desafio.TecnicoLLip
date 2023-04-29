using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto Lazer"/>
    ///</summary>
    [DataContract]
    public class LazerViewModel : Base.Base
    {
        [DataMember]
        public ProdutoViewModel Produto { get; set; }
        [DataMember]
        public TipoLazer TipoLazer { get; set; }
        [DataMember]
        public FamiliaLazer FamiliaLazer { get; set; }
    }
}

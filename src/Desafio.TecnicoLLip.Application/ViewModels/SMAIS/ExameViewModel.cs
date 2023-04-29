using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.SMAIS
{
    public class ExameViewModel : TipoViewModel<int?>
    {
        ///<summary>
        ///Ativo
        ///</summary>
        [DataMember]
        public string Codigo { get; set; }
        ///<summary>
        ///Ativo
        ///</summary>
        [DataMember]
        public string Ativo { get; set; }
    }
}

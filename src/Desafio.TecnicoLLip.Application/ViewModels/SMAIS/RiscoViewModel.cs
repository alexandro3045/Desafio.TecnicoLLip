using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.SMAIS
{
    public class RiscoViewModel : TipoViewModel<int?>
    {
        ///<summary>
        ///Codigo
        ///</summary>
        [DataMember]
        public string Codigo { get; set; }
        ///<summary>
        ///Nome
        ///</summary>
        [DataMember]
        public string Nome { get; set; }
        ///<summary>
        ///CodigoAgenteESocial
        ///</summary>
        [DataMember]
        public string CodigoAgenteESocial { get; set; }
    }
}

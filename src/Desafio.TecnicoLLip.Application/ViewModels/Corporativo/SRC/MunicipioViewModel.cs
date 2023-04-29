using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.SRC
{
    public class MunicipioViewModel : TipoViewModel<int>
    {
        ///<summary>
        ///Código do município.
        ///</summary>
        [DataMember]
        public int? Codigo { get; set; }
        ///<summary>
        ///Sigla da UF.
        ///</summary>
        [DataMember]
        public string SiglaUF { get; set; }
        ///<summary>
        ///UF.
        ///</summary>
        [DataMember]
        public UFViewModel UFViewModel { get; set; }
        ///<summary>
        ///CEP.
        ///</summary>
        [DataMember]
        public string CEP { get; set; }        
    }
}
using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Protheus
{
    ///<summary>
    ///Objeto Empresa"/>
    ///</summary>
    [DataContract]
    public class EmpresaViewModel : TipoViewModel<string>
    {
        [DataMember]
        public string Nome { get; set; }
    }
}
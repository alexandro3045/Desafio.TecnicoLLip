using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto Empresa"/>
    ///</summary>
    [DataContract]
    public class EmpresaViewModel : TipoViewModel<string>
    {
        [DataMember]
        public IEnumerable<GrupoClassificacaoViewModel> GruposClassificacoes { get; set; }
    }
}
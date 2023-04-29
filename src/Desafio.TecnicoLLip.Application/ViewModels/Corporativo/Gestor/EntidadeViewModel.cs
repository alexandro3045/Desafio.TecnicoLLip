using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto EntidadeViewModel"/>
    ///</summary>
    [DataContract]
    public class EntidadeViewModel : TipoViewModel<string>
    {
        [DataMember]
        public IEnumerable<GrupoClassificacao> GruposClassificacoes { get; set; } = null;
    }
}
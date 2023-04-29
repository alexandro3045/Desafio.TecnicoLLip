using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto TipoUnidadeNegocioViewModel"/>
    ///</summary>
    [DataContract]
    public class TipoUnidadeNegocioViewModel : TipoViewModel<Int16>
    {
        [DataMember]
        public string Sigla { get; set; }
        [DataMember]
        public UnidadeVinculada UnidadeVinculada { get; set; }
    }
}

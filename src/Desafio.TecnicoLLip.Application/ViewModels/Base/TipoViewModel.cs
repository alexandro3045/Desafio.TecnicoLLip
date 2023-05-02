using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Base
{
    [DataContract]
    public abstract class TipoViewModel<T> : BaseViewModel<T>
    {
        ///<summary>
        ///Nome da entidade.
        ///</summary>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }


    }
}

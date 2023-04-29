using FluentValidation.Results;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Base
{
    [DataContract]
    public class Base
    {
        ///<summary>
        ///Validation result retorno
        ///</summary>
        [DataMember]
        public ValidationResult ValidationResult { get; set; }

        protected Base() { }
    }

    [DataContract]
    public class BaseViewModel<T> : Base
    {
        ///<summary>
        ///Id da entidade.
        ///</summary>
        [DataMember]
        public T Id { get; set; }
    }
}

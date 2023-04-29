using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio.TecnicoLLip.Domain.Models.Base
{
    public abstract class Base
    {
        ///<summary>
        ///Validation result retorno
        ///</summary>
        [NotMapped]
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

        protected Base() { }
    }

    public abstract class BaseModel<T> : Base
    {
        public T Id { get; set; }

        protected BaseModel() { }
    }
}

#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Domain.Validations;
using FluentValidation;
#endregion

namespace Desafio.TecnicoLLip.Domain.Services.Validations
{
    public class UsersValidator : AbstractValidator<Users>
    {
        public UsersValidator()
        {
            RuleFor(x => x.Email)
                 .IsRequired();

            RuleFor(x => x.Name)
                .IsRequired();

            RuleFor(x => x.Password)
                 .IsRequired();
        }
    }
}
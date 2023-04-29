using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.STI
{
    public class AreaValidator : AbstractValidator<Area>
    {
        public AreaValidator()
        {
            RuleFor(e => e.Descricao)
                .NotNullNotEmpty()
                .MaximumLength(255)
                .WithMessage("{PropertyName} must contain 255 caracters");

            RuleFor(e => e.CodigoDnaArea)
                .NotNullNotEmpty()
                .MaximumLength(3)
                .WithMessage("{PropertyName} must contain 3 caracters");
        }

    }
}

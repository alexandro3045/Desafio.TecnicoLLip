using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC
{
    public class BairroValidator : AbstractValidator<Bairro>
    {
        public BairroValidator()
        {
            RuleFor(e => e.Id)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Descricao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Descricao)
                .MaximumLength(60)
                .WithMessage("{PropertyName} must contain 60 caracters");

            RuleFor(e => e.MunicipioId)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }

    }
}

using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class TussValidator : AbstractValidator<Tuss>
    {
        public TussValidator()
        {
            RuleFor(e => e.Descricao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }

    }
}

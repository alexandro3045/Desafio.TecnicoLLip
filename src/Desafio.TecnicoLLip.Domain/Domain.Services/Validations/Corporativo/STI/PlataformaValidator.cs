using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.STI
{
    public class PlataformaValidator : AbstractValidator<Plataforma>
    {
        public PlataformaValidator()
        {
            RuleFor(e => e.Id)
                .NotNull();

            RuleFor(e => e.Descricao)
                .NotNullNotEmpty()
                .WithMessage("{PropertyName} must contain 80 caracters");

            RuleFor(e => e.CodigoArea)
                .NotNullNotEmpty()
                .WithMessage("{PropertyName} must contain 5 caracters");
        }

    }
}

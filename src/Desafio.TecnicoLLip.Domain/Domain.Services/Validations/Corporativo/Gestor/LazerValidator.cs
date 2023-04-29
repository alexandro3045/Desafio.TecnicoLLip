using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class LazerValidator : AbstractValidator<Lazer>
    {
        public LazerValidator()
        {
            RuleFor(e => e.FamiliaLazer)
                .NotNullNotEmpty();

            RuleFor(e => e.Id)
                .NotNullNotEmpty();

            RuleFor(e => e.TipoLazer)
                .NotNullNotEmpty();
        }

    }
}

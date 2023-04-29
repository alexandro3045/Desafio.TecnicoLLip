using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class SaudeFiguraOdontogramaValidator : AbstractValidator<SaudeFiguraOdontograma>
    {
        public SaudeFiguraOdontogramaValidator()
        {
            RuleFor(e => e.FiguraOdontogramaId)
                .NotNullNotEmpty();

            RuleFor(e => e.SaudeId)
                .NotNullNotEmpty();

        }
    }
}

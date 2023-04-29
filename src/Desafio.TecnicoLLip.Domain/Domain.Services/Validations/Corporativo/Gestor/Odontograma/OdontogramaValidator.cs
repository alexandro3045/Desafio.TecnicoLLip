using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class OdontogramaValidator : AbstractValidator<Odontograma>
    {
        public OdontogramaValidator()
        {
            RuleFor(e => e.NumeroDente)
                .NotNullNotEmpty();

            RuleFor(e => e.Operacao)
                .NotNullNotEmpty();

            RuleFor(e => e.PessoaId)
                .NotNullNotEmpty();

            RuleFor(e => e.FiguraOdontogramaId)
                .NotNullNotEmpty();
        }
    }
}

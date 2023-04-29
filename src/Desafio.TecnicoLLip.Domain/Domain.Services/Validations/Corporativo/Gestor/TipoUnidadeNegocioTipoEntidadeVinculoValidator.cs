using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class TipoUnidadeNegocioTipoEntidadeVinculoValidator : AbstractValidator<TipoUnidadeNegocioTipoEntidadeVinculo>
    {
        public TipoUnidadeNegocioTipoEntidadeVinculoValidator()
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");

            RuleFor(e => e.TipoEntidadeVinculoId)
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");

            RuleFor(e => e.TipoUnidadeNegocioId)
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }
    }
}

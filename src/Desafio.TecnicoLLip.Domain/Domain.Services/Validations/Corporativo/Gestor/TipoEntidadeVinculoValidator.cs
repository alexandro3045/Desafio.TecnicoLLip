using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class TipoEntidadeVinculoValidator : AbstractValidator<TipoEntidadeVinculo>
    {
        public TipoEntidadeVinculoValidator()
        {
            RuleFor(e => e.Descricao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }

    }
}

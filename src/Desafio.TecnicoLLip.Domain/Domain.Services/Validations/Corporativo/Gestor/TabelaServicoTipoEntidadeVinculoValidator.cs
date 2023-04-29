using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class TabelaServicoTipoEntidadeVinculoValidator : AbstractValidator<TabelaServicoTipoEntidadeVinculo>
    {
        public TabelaServicoTipoEntidadeVinculoValidator()
        {
            RuleFor(e => e.Id)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Descricao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

        }

    }
}

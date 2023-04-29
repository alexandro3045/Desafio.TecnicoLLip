using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC
{
    public class RegiaoUnidadeNegocioValidator : AbstractValidator<RegiaoUnidadeNegocio>
    {
        public RegiaoUnidadeNegocioValidator()
        {
            RuleFor(e => e.RegiaoId).NotNull();
            RuleFor(e => e.TipoRegiaoId).NotNull();
            RuleFor(e => e.UnidadeNegocioId).NotNull();
        }

    }
}

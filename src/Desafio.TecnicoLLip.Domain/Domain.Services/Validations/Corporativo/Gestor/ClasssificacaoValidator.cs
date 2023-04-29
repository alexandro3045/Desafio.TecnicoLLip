using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class ClasssificacaoValidator : AbstractValidator<Classificacao>
    {
        public ClasssificacaoValidator()
        {
            RuleFor(e => e.GrupoClassificacaoId)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.ProdutoId)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }

    }
}

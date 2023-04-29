using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC
{
    public class EntidadeValidator : AbstractValidator<Entidade>
    {
        public EntidadeValidator()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }
    }
}
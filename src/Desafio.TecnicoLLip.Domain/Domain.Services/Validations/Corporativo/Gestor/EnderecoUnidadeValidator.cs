using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class EnderecoUnidadeValidator : AbstractValidator<EnderecoUnidade>
    {
        public EnderecoUnidadeValidator()
        {
            RuleFor(e => e.Id)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

        }

    }
}

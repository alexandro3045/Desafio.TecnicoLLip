using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.STI
{
    public class LinhaServicoValidator : AbstractValidator<LinhaServico>
    {
        public LinhaServicoValidator()
        {
            RuleFor(e => e.Id)
                .NotNull();

            RuleFor(e => e.Descricao)
                .NotNullNotEmpty()
                .WithMessage("{PropertyName} must contain 150 caracters");

            RuleFor(e => e.CodigoFuncao)
                .NotNullNotEmpty()
                .WithMessage("{PropertyName} must contain 5 caracters");
        }
    }
}
using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.STI
{
    public class ClassificacaoServicoValidator : AbstractValidator<ClassificacaoServico>
    {
        public ClassificacaoServicoValidator()
        {
            RuleFor(e => e.Id)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Descricao)
                .NotNull()
                .MaximumLength(150)
                .WithMessage("{PropertyName} must contain 150 caracters}");

            RuleFor(e => e.LinhaServicoId)
                .NotNull();

            RuleFor(e => e.AreaDN)
                .NotNull()
                .MaximumLength(5)
                .WithMessage("{PropertyName} must contain 5 caracters}");
        }
    }
}
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Protheus
{
    public class EmpresaValidator : AbstractValidator<Empresa>
    {
        public EmpresaValidator()
        {
            RuleFor(e => e.Id)
              .NotNull()
              .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Descricao)
              .NotNull()
              .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Descricao)
              .NotNull()
              .WithMessage("{PropertyName} must not be null");
        }

    }
}

using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class EmpresaValidator : AbstractValidator<Empresa>
    {
        public EmpresaValidator()
        {
            RuleFor(e => e.Descricao)
              .NotNull()
              .WithMessage("{PropertyName} must not be null")
              .Greater(100);
        }
    }
}

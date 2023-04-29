using Desafio.TecnicoLLip.Domain.Models.SMAIS;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SMAIS
{
    public class RiscoValidator : AbstractValidator<Risco>
    {
        public RiscoValidator()
        {
            RuleFor(x => x.COD)
               .NotNullNotEmpty();

            RuleFor(x => x.NOME)
              .NotNullNotEmpty();
        }
    }
}
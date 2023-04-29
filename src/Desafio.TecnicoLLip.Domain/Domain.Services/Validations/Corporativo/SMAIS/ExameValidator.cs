using Desafio.TecnicoLLip.Domain.Models.SMAIS;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SMAIS
{
    public class ExameValidator : AbstractValidator<Exame>
    {
        public ExameValidator()
        {
            RuleFor(x => x.COD)
               .NotNullNotEmpty();

            RuleFor(x => x.DESCRICAO)
              .NotNullNotEmpty();
        }
    }
}
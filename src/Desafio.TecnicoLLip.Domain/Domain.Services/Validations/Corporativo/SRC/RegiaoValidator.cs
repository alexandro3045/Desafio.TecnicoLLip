using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC
{
    public class RegiaoValidator : AbstractValidator<Regiao>
    {
        public RegiaoValidator()
        {
            RuleFor(e => e.Descricao)
                .NotNullNotEmpty()
                .Greater(100);

            RuleFor(e => e.TipoRegiaoId)
                .NotNullNotEmpty();
        }

    }
}

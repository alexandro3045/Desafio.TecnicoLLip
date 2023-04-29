using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.SRC
{
    public class TipoRegiaoValidator : AbstractValidator<TipoRegiao>
    {
        public TipoRegiaoValidator()
        {
            RuleFor(x => x.Descricao)
                .NotNullNotEmpty()
                .Greater(25);
        }
    }
}

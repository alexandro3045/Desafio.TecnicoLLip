using Desafio.TecnicoLLip.Domain.Models.Corporativo.Saude;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Saude
{
    public class ProdutoTipoFichaValidator : AbstractValidator<ProdutoTipoFicha>
    {
        public ProdutoTipoFichaValidator()
        {

            RuleFor(e => e.ProdutoId)
                .IsRequired();

            RuleFor(e => e.ServicoId)
                .IsRequired();

            RuleFor(e => e.TipoFichaId)
                .IsRequired();
        }

    }
}

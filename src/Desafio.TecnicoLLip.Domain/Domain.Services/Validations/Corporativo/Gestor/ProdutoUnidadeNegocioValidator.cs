using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class ProdutoUnidadeNegocioValidator : AbstractValidator<ProdutoUnidadeNegocio>
    {
        public ProdutoUnidadeNegocioValidator()
        {
            RuleFor(e => e.Inicio).NotNullNotEmpty();
            RuleFor(e => e.ProdutoId).NotNullNotEmpty();
            RuleFor(e => e.UnidadeNegocioId).NotNullNotEmpty();
            RuleFor(e => e.ExecutaServicoOferecido)
                .NotNullNotEmpty();

        }

    }
}

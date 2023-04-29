using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class ClasseValorProdutoValidator : AbstractValidator<ClasseValorProduto>
    {
        public ClasseValorProdutoValidator()
        {
            RuleFor(e => e.CodigoEmpresa)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.CodigoCentroResponsabilidade)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.Inicio)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.ProdutoId)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }

    }
}

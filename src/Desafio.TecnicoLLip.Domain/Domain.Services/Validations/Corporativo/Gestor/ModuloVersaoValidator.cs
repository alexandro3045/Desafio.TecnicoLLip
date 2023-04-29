using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class ModuloVersaoValidator : AbstractValidator<ModuloVersao>
    {
        public ModuloVersaoValidator()
        {
            RuleFor(e => e.CustoSistema)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.IdadeMinimaEducacao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");

            RuleFor(e => e.IdadeMaximaEducacao)
                .NotNull()
                .WithMessage("{PropertyName} must not be null");
        }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class EmpresaEntidadeVinculoValidator : AbstractValidator<EmpresaEntidadeVinculo>
    {
        public EmpresaEntidadeVinculoValidator()
        {
            RuleFor(e => e.EmpresaId)
             .Greater(1);

            RuleFor(e => e.TipoEntidadeVinculoId)
            .Greater(2);
        }

    }
}

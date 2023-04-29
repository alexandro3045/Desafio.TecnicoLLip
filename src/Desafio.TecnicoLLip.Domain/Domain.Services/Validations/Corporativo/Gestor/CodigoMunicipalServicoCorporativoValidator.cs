using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class CodigoMunicipalServicoCorporativoValidator : AbstractValidator<CodigoMunicipalServicoCorporativo>
    {
        public CodigoMunicipalServicoCorporativoValidator()
        {
            RuleFor(e => e.CodigoServicoOficial).NotNull();
            RuleFor(e => e.Inicio).NotNull();
            RuleFor(e => e.CodigoMunicipio).NotNull();
            RuleFor(e => e.CodigoMunicipalId).NotNull();
        }

    }
}

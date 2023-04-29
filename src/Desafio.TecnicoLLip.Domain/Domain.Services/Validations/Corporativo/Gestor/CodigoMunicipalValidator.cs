using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class CodigoMunicipalValidator : AbstractValidator<CodigoMunicipal>
    {
        public CodigoMunicipalValidator()
        {
            RuleFor(e => e.Id).NotNull();
            RuleFor(e => e.Descricao).NotNull();
            RuleFor(e => e.MunicipioId).NotNull();
        }
    }
}

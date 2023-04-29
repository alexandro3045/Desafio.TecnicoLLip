using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class GrupoClassificacaoValidator : AbstractValidator<GrupoClassificacao>
    {
        public GrupoClassificacaoValidator()
        {
            RuleFor(e => e.Nome)
                .NotNullNotEmpty();

            RuleFor(e => e.NumeroOrdem)
                .NotNullNotEmpty();

            RuleFor(e => e.CodigoTipoEntidadeVinculo)
                .NotNullNotEmpty();

            RuleFor(e => e.Fim)
                .NotNullNotEmpty();

            RuleFor(e => e.NivelServico)
                .NotNullNotEmpty();

            RuleFor(e => e.IndicadorProduto)
                .NotNullNotEmpty();
        }

    }
}

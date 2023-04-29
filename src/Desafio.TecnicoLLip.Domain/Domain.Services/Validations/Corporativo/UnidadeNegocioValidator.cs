﻿using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo
{
    public class UnidadeNegocioValidator : AbstractValidator<UnidadeNegocio>
    {
        public UnidadeNegocioValidator()
        {
            RuleFor(x => x.Descricao)
                 .NotNullNotEmpty();

            RuleFor(x => x.EmpresaSistemaCNICoordenadoraId)
                .IsRequired();

            RuleFor(x => x.TipoUnidadeId)
                 .IsRequired();

            RuleFor(x => x.Prestador)
                 .NotNullNotEmpty();

            RuleFor(x => x.FazFaturamento)
                .BoolNotNullNotEmpty();

            RuleFor(x => x.AceitaPreco)
                .BoolNotNullNotEmpty();

            RuleFor(x => x.AutorizaDivulgacao)
                .BoolNotNullNotEmpty();

            RuleFor(x => x.AtendimentoCentralizado)
                .BoolNotNullNotEmpty();

            RuleFor(x => x.AtivoAssistMarca)
                .BoolNotNullNotEmpty();

            RuleFor(x => x.AtivoOcupDesMarca)
                .BoolNotNullNotEmpty();

        }
    }
}
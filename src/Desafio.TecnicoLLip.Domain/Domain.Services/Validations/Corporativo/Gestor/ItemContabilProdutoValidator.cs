﻿using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using FluentValidation;

namespace Desafio.TecnicoLLip.Domain.Validations.Corporativo.Gestor
{
    public class ItemContabilProdutoValidator : AbstractValidator<ItemContabilProduto>
    {
        public ItemContabilProdutoValidator()
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

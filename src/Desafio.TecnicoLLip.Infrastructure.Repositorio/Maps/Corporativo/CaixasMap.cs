﻿using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo
{
    public class CaixasMap : IEntityTypeConfiguration<Caixas>
    {
        public void Configure(EntityTypeBuilder<Caixas> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("C_CAIXA")
               .IsRequired();

            builder
                .Property(e => e.Descricao)
                .HasColumnName("DESC_CX");

            builder
                .ToTable("Caixas_IQ");
        }
    }
}
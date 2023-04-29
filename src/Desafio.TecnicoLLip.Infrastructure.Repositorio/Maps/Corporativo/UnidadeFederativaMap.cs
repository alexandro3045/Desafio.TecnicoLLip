﻿using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo
{
    public class UnidadeFederativaMap : IEntityTypeConfiguration<UnidadeFederativa>
    {
        public void Configure(EntityTypeBuilder<UnidadeFederativa> builder)
        {
            builder
                .Property(e => e.Id)
                .HasColumnName("ch_sg_uf")
                .IsRequired();

            builder
                .Property(e => e.Descricao)
                .HasColumnName("vc_nm_uf");

            builder
                .ToTable("UF");
        }
    }
}

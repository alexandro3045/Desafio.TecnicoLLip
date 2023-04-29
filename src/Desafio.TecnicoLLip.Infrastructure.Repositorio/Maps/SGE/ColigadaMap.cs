using Desafio.TecnicoLLip.Domain.Models.SGE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.SGE
{
    public class ColigadaMap : IEntityTypeConfiguration<Coligada>
    {
        public void Configure(EntityTypeBuilder<Coligada> builder)
        {
            builder
                .Property(e => e.Id)
                .HasMaxLength(2)
                .HasColumnName("CODCOLIGADA")
                .HasColumnType("Int16")
                .IsRequired(true);

            builder.Property(e => e.Descricao)
                .HasColumnName("NOMEFANTASIA")
                .HasColumnType("varchar")
                .HasMaxLength(60)
                .IsRequired();

            builder
                .ToTable("GCOLIGADA");
        }
    }
}
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor
{
    public class TipoContratoMap : IEntityTypeConfiguration<TipoContrato>
    {
        public void Configure(EntityTypeBuilder<TipoContrato> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("si_sq_tipocontrato")
               .HasColumnType("smallint")
               .HasMaxLength(2)
               .IsRequired(true);

            builder
              .Property(e => e.Descricao)
              .HasColumnName("vc_ds_tipocontrato")
              .HasColumnType("varchar")
              .HasMaxLength(80);

            builder
                .ToTable("TipoContrato");
        }
    }
}
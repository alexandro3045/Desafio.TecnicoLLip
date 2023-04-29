using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor
{
    public class TipoRiscoMap : IEntityTypeConfiguration<TipoRisco>
    {
        public void Configure(EntityTypeBuilder<TipoRisco> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("ch_nr_tiporisco")
               .IsRequired(true);

            builder
                .HasKey(e => e.Id);

            builder
               .Property(e => e.Descricao)
               .HasColumnName("vc_nm_tiporisco")
               .HasColumnType("varchar")
               .HasMaxLength(100)
               .IsRequired(true);
        }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor
{
    public class AgenteMap : IEntityTypeConfiguration<Agente>
    {
        public void Configure(EntityTypeBuilder<Agente> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("ch_nr_agente")
               .HasColumnType("char")
               .HasMaxLength(4)
               .IsRequired(true);

            builder
                .HasKey(e => e.Id);

            builder
               .Property(e => e.Descricao)
               .HasColumnName("vc_nm_agente")
               .HasColumnType("varchar")
               .HasMaxLength(3000)
               .IsRequired(true);

            builder
                .ToTable("Agente");
        }
    }
}
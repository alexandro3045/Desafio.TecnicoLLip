using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo
{
    public class LoggerMap : IEntityTypeConfiguration<Logger>
    {
        public void Configure(EntityTypeBuilder<Logger> builder)
        {
            builder
                .Property(e => e.Id)
                .HasColumnName("in_sq_mensagem")
                .IsRequired();

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Mesage)
                .HasColumnName("vc_ds_mensagem");

            builder
                 .Property(e => e.Type)
                 .HasColumnName("vc_tp_type");

            builder
                 .Property(e => e.Source)
                 .HasColumnName("vc_ds_source");

            builder
                 .Property(e => e.Json)
                 .HasColumnName("vc_ds_json");

            builder
                 .Property(e => e.EventDate)
                 .HasColumnName("sd_dt_event");

            builder
                .ToTable("IntegrationDynamics");
        }
    }
}

using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor
{
    public class ModalidadeMap : IEntityTypeConfiguration<Modalidade>
    {
        public void Configure(EntityTypeBuilder<Modalidade> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("si_sq_modalidade")
               .HasColumnType("smallint")
               .HasMaxLength(2)
               .IsRequired(true);

            builder
              .Property(e => e.Descricao)
              .HasColumnName("vc_ds_modalidade")
              .HasColumnType("varchar")
              .HasMaxLength(120);

            builder
              .Property(e => e.TipoEntidade)
              .HasColumnName("ch_tp_entidade")
              .HasMaxLength(1)
              .HasConversion(
                  v => v.Id,
                  v => (TipoEntidade)Enums<char?>.Parse<TipoEntidade>(v))
              .IsUnicode(false);

            builder
              .Property(e => e.Fim)
              .HasColumnType("datetime")
              .HasColumnName("sd_dt_fim_modalidade")
              .HasMaxLength(4);

            builder
                .ToTable("Modalidade");
        }
    }
}
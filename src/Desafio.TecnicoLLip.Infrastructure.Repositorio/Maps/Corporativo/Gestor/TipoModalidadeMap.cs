using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor
{
    public class TipoModalidadeMap : IEntityTypeConfiguration<TipoModalidade>
    {
        public void Configure(EntityTypeBuilder<TipoModalidade> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("si_sq_tipomodal")
               .HasColumnType("smallint")
               .HasMaxLength(2)
               .IsRequired(true);

            builder
                .HasKey(e => e.Id);

            builder
               .Property(e => e.Descricao)
               .HasColumnName("vc_ds_tipomodal")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsRequired(true);

            builder
               .Property(e => e.Codigo)
               .HasColumnName("ch_cd_tipomodal")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsRequired(true);

            builder
               .Property(e => e.CodigoDN)
               .HasColumnName("ch_cd_DN_tipomodal")
               .HasColumnType("char")
               .HasMaxLength(3)
               .IsRequired(true);

            builder
               .Property(e => e.ModalidadeId)
               .HasColumnType("smallint")
               .HasColumnName("si_sq_modalidade")
               .IsRequired(true)
               .HasMaxLength(2);

            builder
              .HasOne(a => a.Modalidade)
              .WithMany()
              .HasForeignKey(s => s.ModalidadeId)
              .IsRequired();

            builder
              .Property(e => e.Acao)
              .HasColumnName("ch_fg_acao_tipomodal")
              .HasMaxLength(1)
              .HasConversion(
                  v => v.Id,
                  v => (Acao)Enums<char?>.Parse<Acao>(v))
              .IsUnicode(false);

            builder
                .ToTable("TipoModalidade");
        }
    }
}
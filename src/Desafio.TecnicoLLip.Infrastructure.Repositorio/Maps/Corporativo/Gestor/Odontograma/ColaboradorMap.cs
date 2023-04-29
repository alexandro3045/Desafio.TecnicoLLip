using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor.Odontograma
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder
               .Property(e => e.PessoaId)
               .HasColumnName("in_sq_pessoa")
               .HasColumnType("int")
               .HasMaxLength(4)
               .IsRequired(true);

            builder
                .HasKey(e => e.PessoaId);


            builder
              .HasOne(a => a.Pessoa)
              .WithMany()
              .HasForeignKey(s => s.PessoaId);

            builder
                .Ignore(e => e.Id);

            builder
                .Ignore(e => e.Descricao);

            builder
               .Property(e => e.Inicio)
               .HasColumnName("sd_dt_inicio_colaborador")
               .HasColumnType("smalldatetime");

            builder
               .Property(e => e.Fim)
               .HasColumnName("sd_dt_fim_colaborador")
               .HasColumnType("smalldatetime");

            builder
              .Property(e => e.Qualificador)
              .HasColumnName("ch_ql_colaborador")
              .HasMaxLength(1)
              .HasConversion(
                  v => v.Id,
                  v => (Qualificador)Enums<char?>.Parse<Qualificador>(v))
              .IsUnicode(false)
              .IsRequired(true);

            builder
               .Property(e => e.Cancelamento)
               .HasColumnName("sd_dt_cancel_colaborador")
               .HasColumnType("smalldatetime");

            builder
                .ToTable("Colaborador");
        }
    }
}
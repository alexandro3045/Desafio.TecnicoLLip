using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("ch_cd_empresa")
               .HasConversion(
                 v => v,
                 v => v.Trim());

            builder
                .HasKey(e => new { e.Id });

            builder
                .Property(e => e.Descricao)
                .HasColumnName("vc_nm_empresa");

            builder
                .ToTable("Empresa");
        }
    }
}
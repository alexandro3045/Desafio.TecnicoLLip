using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo
{
    public class EmpresaSistemaCniCoordenadoraMap : IEntityTypeConfiguration<EmpresaSistemaCniCoordenadora>
    {
        public void Configure(EntityTypeBuilder<EmpresaSistemaCniCoordenadora> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("in_sq_entidade")
               .IsRequired();

            builder.HasKey(a => a.Id);

            builder
                .Property(e => e.Sigla)
                .HasColumnName("vc_sg_empresacni");

            builder
                .Property(e => e.Descricao)
                .HasColumnName("vc_nr_resolucaoexec_empresacni");

            builder
                .ToTable("EmprSistCNI");
        }
    }
}
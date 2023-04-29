using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo
{
    public class EstabelecimentoMap : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("ch_cd_IdEstabelecimento")
               .IsRequired();

            builder
                .Property(e => e.Descricao)
                .HasColumnName("vc_ds_Nome");

            builder
                .ToTable("Estabelecimento");
        }
    }
}
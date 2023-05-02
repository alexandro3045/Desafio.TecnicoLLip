#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps
{
    public class ProjectsMap : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder
                .Property(e => e.Title)
                .HasColumnName("Title");

            builder
                .Property(e => e.Description)
                .HasColumnName("Description");

            builder
                .Property(e => e.CreationDate)
                .HasColumnName("CreationDate");

            builder
                .ToTable("Projects");
        }
    }
}
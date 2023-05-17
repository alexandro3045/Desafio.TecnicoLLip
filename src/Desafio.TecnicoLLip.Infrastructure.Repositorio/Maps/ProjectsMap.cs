#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps
{
    public class ProjectsMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
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
                .HasMany(a=>a.Activities)
                .WithOne(p=> p.Project)
                .HasForeignKey(r => r.ProjectId);

            builder
                .ToTable("Projects");
        }
    }
}
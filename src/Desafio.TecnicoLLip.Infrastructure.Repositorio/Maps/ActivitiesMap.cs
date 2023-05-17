#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Desafio.TecnicoLLip.Domain.Models.Utility;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps
{
    public class ActivitiesMap : IEntityTypeConfiguration<Activities>
    {
        public void Configure(EntityTypeBuilder<Activities> builder)
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
                .HasOne(a => a.Project)
                .WithMany(p => p.Activities)
                .HasForeignKey(r => r.ProjectId);

            builder
                .HasOne(r => r.Resposavel)
                .WithOne(a => a.Activities)
                .HasForeignKey<Users>(s => s.Id);

            builder
                .Property(e => e.ProjectId)
                .HasColumnName("ProjectId");

            builder
                .Property(e => e.UserId)
                .HasColumnName("UserId");

            builder
              .Property(e => e.Status)
              .HasColumnName("Status")
              .HasMaxLength(1)
              .HasConversion(
                  v => v.Id,
                  v => (EnumStatus)Enums<char?>.Parse<EnumStatus>(v))
              .IsUnicode(false);                

            builder
                .ToTable("Activities");
        }
    }
}
#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Maps
{
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder
               .Property(e => e.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder
                .Property(e => e.Name)
                .HasColumnName("Name");

            builder
                .Property(e => e.Email)
                .HasColumnName("Email");

            builder
                .Property(e => e.Password)
                .HasColumnName("Password");

            builder
                .ToTable("Users");
        }
    }
}
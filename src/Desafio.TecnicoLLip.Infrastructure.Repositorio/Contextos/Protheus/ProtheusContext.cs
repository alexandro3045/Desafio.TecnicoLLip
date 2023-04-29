using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Protheus;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Protheus
{
    public class ProtheusContext : DbContext
    {
        public ProtheusContext(DbContextOptions<ProtheusContext> options) : base(options)
        {
#if DEBUG
            this.ConfigureLogging(s => Console.Write(s), LoggingCategories.SQL);
#endif
        }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationFailure>();

            modelBuilder.Ignore<ValidationResult>();

            modelBuilder.ApplyConfiguration(new EmpresaMap());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
using Desafio.TecnicoLLip.Domain.Models.SGE;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.SGE;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Contextos.SGE
{
    public class SgeContext : DbContext
    {
        public SgeContext(DbContextOptions<SgeContext> options) : base(options)
        {
#if DEBUG
            this.ConfigureLogging(s => Console.Write(s), LoggingCategories.SQL);
#endif
        }

        public DbSet<ModalidadeCurso> ModalidadesCursos { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Coligada> Coligadas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Ignore<ValidationFailure>();

            modelBuilder
                .Ignore<ValidationResult>();

            modelBuilder
                .ApplyConfiguration(new ColigadaMap());

            modelBuilder
                .ApplyConfiguration(new AreaSGEMap());

            modelBuilder
                .ApplyConfiguration(new ModalidadeCursoMap());

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
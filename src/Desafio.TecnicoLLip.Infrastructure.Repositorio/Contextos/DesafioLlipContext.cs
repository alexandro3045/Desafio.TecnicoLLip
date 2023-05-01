#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps;
using FluentValidation.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo
{
    public class DesafioLlipContext : DbContext
    {
        public DesafioLlipContext(DbContextOptions<DesafioLlipContext> options, IHostingEnvironment env) : base(options)
        {
#if DEBUG
            this.ConfigureLogging(s => Console.Write(s), LoggingCategories.SQL);
#endif
            int? e = Database.GetCommandTimeout();

            Database.SetCommandTimeout(e.HasValue ? e + 12000 : 12000);
        }

        #region DbSets
        public DbSet<Users> Users { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Aply Configuration Mapper

            modelBuilder
                .Ignore<ValidationFailure>();

            modelBuilder
                .Ignore<ValidationResult>();

            modelBuilder
                .ApplyConfiguration(new UsersMap());
            #endregion

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

        public static readonly LoggerFactory LoggerFactory = new LoggerFactory(new[] { new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider() });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .ConfigureWarnings(bulder =>
                      bulder
                      .Default(WarningBehavior.Ignore)
               );

            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
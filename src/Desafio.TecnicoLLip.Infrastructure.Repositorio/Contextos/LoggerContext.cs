using EntityFramework.Triggers;
using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Microsoft.EntityFrameworkCore;
using System;
//using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Base;
//using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
//using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.IO;
//using System.Linq;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Contextos
{
    public class LoggerContext : DbContextWithTriggers
    {
        //public LoggerContext(DbContextOptions<LoggerContext> options) //: base(options)
        //{
        //#if DEBUG
        //   this.ConfigureLogging(s => Console.Write(s), LoggingCategories.SQL);
        //#endif
        //}

        public LoggerContext(IServiceProvider serviceProvider) : base(serviceProvider) { }
        public LoggerContext(IServiceProvider serviceProvider, DbContextOptions options) : base(serviceProvider) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(GetConnectionString(GetType().FullName));
        //}

        public DbSet<Logger> Loggers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder
        //        .ApplyConfiguration(new LoggerMap());

        //    foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        //    {
        //        relationship.DeleteBehavior = DeleteBehavior.Restrict;
        //    }
        //    base.OnModelCreating(modelBuilder);

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //       .ConfigureWarnings(bulder =>
        //              bulder
        //              .Default(WarningBehavior.Ignore)
        //       );
        //    new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //}
    }
}
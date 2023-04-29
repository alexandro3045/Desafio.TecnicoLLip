using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo;
using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using System;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo
{
    public class LoggerRepositorio : IDisposable, ILoggerRepository
    {
        protected DbSet<Logger> DbSet;
        public LoggerContext Contexto { get; set; }
        public LoggerRepositorio(LoggerContext context)
        {
            Contexto = context;
            //DbSet = context.Set<Logger>();
        }

        public void Save(Logger logger)
        {
            Contexto.Entry(logger).State = (System.Data.Entity.EntityState)EntityState.Modified;
            DbSet.Add(logger);
            Contexto.SaveChanges();
        }

        #region IDisposable Support
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Contexto?.Dispose();
            }
        }

        ~LoggerRepositorio()
        {
            Dispose(false);
        }
        #endregion
    }
}

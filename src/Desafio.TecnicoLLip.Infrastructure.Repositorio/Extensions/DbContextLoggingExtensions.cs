using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Extensions
{
    public enum LoggingCategories
    {
        All = 0,
        SQL = 1
    }

    public static class DbContextLoggingExtensions
    {
        public static void ConfigureLogging(this DbContext db, Action<String> logger, Func<string, LogLevel, bool> filter)
        {
            var serviceProvider = db.GetInfrastructure();
            var loggerFactory = (ScopedLoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));

            LogProvider.CreateOrModifyLoggerForDbContext(db.GetType(), loggerFactory, logger, filter);
        }

        public static void ConfigureLogging(this DbContext db, Action<String> logger,
                                           LoggingCategories categories = LoggingCategories.All) {
            var serviceProvider = db.GetInfrastructure();
            var loggerFactory = (ScopedLoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));

            if (categories == LoggingCategories.SQL)
            {
                var SqlCategories = new List<string> { DbLoggerCategory.Database.Command.Name,
                                                       DbLoggerCategory.Query.Name,
                                                       DbLoggerCategory.Update.Name };

                LogProvider.CreateOrModifyLoggerForDbContext(db.GetType(),
                                                             loggerFactory,
                                                             logger,
                                                             (c, l) => SqlCategories.Contains(c));
            }
            else if (categories == LoggingCategories.All)
            {
                LogProvider.CreateOrModifyLoggerForDbContext(db.GetType(),
                                                             loggerFactory, logger,
                                                             (c, l) => true);
            }
        }

    }

    internal class LogProvider : ILoggerProvider
    {
        public volatile LoggingConfiguration Configuration;
        static bool DefaultFilter(string CategoryName, LogLevel level) => true;

        static readonly ConcurrentDictionary<Type, LogProvider> providers = new ConcurrentDictionary<Type, LogProvider>();

        public static void CreateOrModifyLoggerForDbContext(Type DbContextType,
                                                            ScopedLoggerFactory loggerFactory,
                                                            Action<string> logger,
                                                            Func<string, LogLevel, bool> filter = null){
            bool isNew = false;
            var provider = providers.GetOrAdd(DbContextType, t =>
            {
                var p = new LogProvider(logger, filter ?? DefaultFilter);
                loggerFactory.AddProvider(p);
                isNew = true;

                return p;
            });

            if (!isNew)
            {
                provider.Configuration = new LoggingConfiguration(logger, filter ?? DefaultFilter);
            }

        }
        public class LoggingConfiguration
        {
            public LoggingConfiguration(Action<string> logger, Func<string, LogLevel, bool> filter)
            {
                this.logger = logger;
                this.filter = filter;
            }
            public readonly Action<string> logger;
            public readonly Func<string, LogLevel, bool> filter;
        }

        private LogProvider(Action<string> logger, Func<string, LogLevel, bool> filter)
        {
            this.Configuration = new LoggingConfiguration(logger, filter);
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new Logger(categoryName, this);
        }

        private class Logger : ILogger
        {
            readonly string categoryName;
            readonly LogProvider provider;
            public Logger(string categoryName, LogProvider provider)
            {
                this.provider = provider;
                this.categoryName = categoryName;
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state,
                                    Exception exception, Func<TState, Exception, string> formatter) {
                var config = provider.Configuration;

                if (config.filter(categoryName, logLevel))
                {
                    config.logger(formatter(state, exception));
                }
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }
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
                providers?.Clear();
                Configuration = null;
            }
        }

        ~LogProvider()
        {
            Dispose(false);
        }
        #endregion
    }
}
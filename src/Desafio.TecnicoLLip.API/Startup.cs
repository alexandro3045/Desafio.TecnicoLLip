using AutoMapper;
using EntityFramework.Triggers;
using Desafio.TecnicoLLip.API.Settings;
using Desafio.TecnicoLLip.Application.AutoMapperConfigs;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Services;
using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.CrossCutting;
using Desafio.TecnicoLLip.Infrastructure.Data.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics;
using ControllersOptions = Desafio.TecnicoLLip.API.Settings.ControllersOptions;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.SGE;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Protheus;

namespace Desafio.TecnicoLLip.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public IWebHostEnvironment Environment { get; set; }

        //public IEmailAppService EmailAppService { get; set; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment/*, IEmailAppService emailAppService*/)
        {
            Configuration = configuration;

            Environment = environment;

           // EmailAppService = emailAppService;
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container. 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });

            services.AddApplicationInsightsTelemetry();

            services
                .AddApiVersioning(o =>
                {
                    o.ReportApiVersions = true;
                    o.AssumeDefaultVersionWhenUnspecified = true;
                    o.DefaultApiVersion = new ApiVersion(1, 0);
                    o.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
                });

            services.Configure<Microsoft.AspNetCore.ResponseCompression.GzipCompressionProviderOptions>(
                options => options.Level = System.IO.Compression.CompressionLevel.Optimal);

            services.AddResponseCompression(options =>
            {
                options.Providers.Add<Microsoft.AspNetCore.ResponseCompression.GzipCompressionProvider>();
                options.EnableForHttps = true;
            });

            services
                .AddLogging(loggingBuilder =>
                {
                    loggingBuilder
                        .AddConfiguration(Configuration.GetSection("Logging"));

                    loggingBuilder
                        .AddConsole();

                    loggingBuilder
                        .AddDebug();
                });

            services
                .AddOptions();

            services
                .AddApiVersioning();

            ControllersOptions
                .AddService(services);

            ServicosAdicionais(services);

            services.AddTriggers();
        }

        /// <summary>
        ///  This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            if (env.IsDevelopment())
            {
                app
                  .UseDeveloperExceptionPage();

                builder
                  .AddUserSecrets<Startup>();
            }
            else
            {
                app
                 .UseHsts();
            }

            app
              .UseHttpsRedirection();

            ControllersOptions
                .Configure(app);

            ConfiguracoesAdicionais(app, env);

            app.UseTriggers(builder =>
            {
                builder.Triggers().Inserted.Add(entry => Debug.WriteLine(entry.Entity.ToString()));
                //builder.Triggers<Logger, LoggerContext>().Inserted.Add(entry => Debug.WriteLine(entry.Entity.Mesage));
            });
        }

        public void AddDbContext<TContext>(IServiceCollection services, string connection) where TContext : DbContext
        {
            services
                .AddDbContext<TContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString(connection), options =>
                {
                    options.EnableRetryOnFailure(
                        maxRetryCount: 10,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);
                }
                )
                .EnableSensitiveDataLogging(Environment.IsDevelopment())
                .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll));
        }

        protected virtual void ServicosAdicionais(IServiceCollection services)
        {
            AddDbContext<CorporativoContext>(services, "Corporativo");

            AddDbContext<SgeContext>(services, "SGE");

            AddDbContext<ProtheusContext>(services, "PROTHEUS");

            //AddDbContext<LoggerContext>(services, "Corporativo");

            services
                .AddLogging();

            services
                .AddAutoMapper(x => x.AddProfile(new MappingProfile()), typeof(MappingProfile));

            Injections
                .RegistrarServicos(services);

            SwaggerApi
                .AddService(services);

            Injections
                .RegistrarSeguranca(services, Configuration);

            if (Environment.IsDevelopment())
            {
                services
                    .AddControllers(opts =>
                    {
                        opts.Filters.Add(new AllowAnonymousFilter());
                    });
            }
        }

        protected virtual void ConfiguracoesAdicionais(IApplicationBuilder app, IWebHostEnvironment env) => SwaggerApi.Configure(app);
    }
}
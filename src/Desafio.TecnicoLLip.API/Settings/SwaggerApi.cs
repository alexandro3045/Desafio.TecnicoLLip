using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace Desafio.TecnicoLLip.API.Settings
{
    /// <summary>
    /// Configurações de Startup para o Swagger
    /// </summary>
    public static class SwaggerApi
    {
        private const string URITERMSOFSERVICE = "https://www.desafiotecnicoLLip.com.br/terms";
        private const string URLCONTACT = "https://www.desafiotecnicoLLip.com.br";
        private const string URLLICENSE = "https://www.desafiotecnicoLLip.com.br";
        /// <summary>
        /// Adiciona a configuração de serviço do Swagger
        /// </summary>
        /// <param name="services">Coleção de serviços</param>
        public static void AddService(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Desafio Técnico LLip API",
                    Description = "API da LLip em .net Core 3.1",
                    TermsOfService = new Uri(URITERMSOFSERVICE),
                    Contact = new OpenApiContact
                    {
                        Name = "LLIP",
                        Email = "alexandro.alves@yahoo.com.br",
                        Url = new Uri(URLCONTACT)
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Llip",
                        Url = new Uri(URLLICENSE)
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                c.CustomSchemaIds(i => i.FullName);
            });

            services.ConfigureSwaggerGen(swaggerGen =>
            {
                swaggerGen.OperationFilter<ApiVersionFilter>();
            });
        }

        /// <summary>
        /// Configura o Swagger
        /// </summary>
        /// <param name="app">Aplicação</param>
        public static void Configure(IApplicationBuilder app)
        {
            app.UseSwagger(c =>
            {
                c.RouteTemplate = "swagger/{documentName}/swagger.json";
            });

            app.UseSwaggerUI(c =>
            {
                string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
                c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Desafio Técnico LLIP API v1");
            });
        }
    }
}
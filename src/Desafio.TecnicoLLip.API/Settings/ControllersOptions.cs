using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Desafio.TecnicoLLip.API.Settings
{
    /// <summary>
    /// Configuração do MVC
    /// </summary>
    public static class ControllersOptions
    {
        /// <summary>
        /// Nome do Cache Profile utilizado
        /// </summary>
        public const string CacheProfileName = "NonAuthoritativeLongDatabaseDuration";

        public const string CorsPolicyName = "CorsPolicy";

        /// <summary>
        /// Adiciona o serviço de MVC
        /// </summary>
        /// <param name="services">Colleção de serviços</param>
        public static void AddService(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.CacheProfiles.Add(ControllersOptions.CacheProfileName, new CacheProfile
                {
                    Duration = (int)TimeSpan.FromMinutes(500).TotalSeconds,
                    Location = ResponseCacheLocation.Any,
                });
            });
        }

        /// <summary>
        /// Configura o MVC
        /// </summary>
        /// <param name="app">Aplicação</param>
        public static void Configure(IApplicationBuilder app)
        {
            app
             .UseResponseCompression();

            app
             .UseRouting();

            app
             .UseAuthentication();

            app
             .UseAuthorization();

            app
             .UseEndpoints(endpoints =>
             {
                endpoints.MapDefaultControllerRoute();
             });
        }
    }
}

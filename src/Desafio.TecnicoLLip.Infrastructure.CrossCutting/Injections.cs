#region Includes 
using AutoMapper;
using Desafio.TecnicoLLip.Application.AutoMapperConfigs;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Desafio.TecnicoLLip.Domain.Services.Validations;
using Desafio.TecnicoLLip.Domain.Services.Services;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.CrossCutting
{
    public class Injections
    {
        protected Injections() { }

        public static void RegistrarServicos(IServiceCollection services)
        {
            services
                .AddSingleton<AutoMapper.IConfigurationProvider>(AutoMapperConfig.RegisterMappings());

            services
                .AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));

            #region Add singleton
            services
                .AddSingleton<UsersValidator>();
            services
                .AddSingleton<ProjectsValidator>();
            #endregion

            #region Add Scoped AppService
            services
                .AddScoped<IEmailAppService, EmailAppService>();
            services
                .AddScoped<ILoginAppService, LoginAppService>();
            services
                .AddScoped<IUsuarioAppService, UsuarioAppService>();
            services
                .AddScoped<IProjetoAppService, ProjetoAppService>();
            #endregion

            #region Add Scoped Service
            services
                .AddScoped<IUsersService, UsersService>();
            services
                .AddScoped<IProjectsService, ProjectsService>();
            #endregion

            #region Add Scoped Repository
            services
                .AddScoped<IUsersRepository, UsersRepositorio>();
            services
                .AddScoped<IProjectsRepository, ProjectsRepositorio>();
            #endregion
        }

        public static void RegistrarSeguranca(IServiceCollection services, IConfiguration configuration)
        {
            var tokenConfigurations = new Application.Security.Configuration.TokenConfiguration();
            var signingConfigurations = new Application.Security.Configuration.SigningConfigurations();

            services.AddSingleton<IConfiguration>(provider => configuration);

            new Microsoft.Extensions.Options.ConfigureFromConfigurationOptions<Application.Security.Configuration.TokenConfiguration>(
                configuration.GetSection("TokenConfigurations")
            )
            .Configure(tokenConfigurations);

            services.AddSingleton(tokenConfigurations);

            services.AddSingleton(signingConfigurations);

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;
                paramsValidation.ValidateIssuerSigningKey = true;
                paramsValidation.ValidateLifetime = true;
                paramsValidation.ClockSkew = System.TimeSpan.Zero;
            });

            services.AddAuthorization(auth =>
            {
                auth
                  .AddPolicy("Bearer", new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder()
                  .AddAuthenticationSchemes(Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme‌​)
                  .RequireAuthenticatedUser()
                  .Build());
            });
        }
    }
}
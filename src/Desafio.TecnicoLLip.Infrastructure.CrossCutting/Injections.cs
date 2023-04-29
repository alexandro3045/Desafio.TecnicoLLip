#region Includes 
using AutoMapper;
using Desafio.TecnicoLLip.Application.AutoMapperConfigs;
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.CrossCutting
{
    public class Injections
    {
        protected Injections() { }

        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddSingleton<AutoMapper.IConfigurationProvider>(AutoMapperConfig.RegisterMappings());

            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));

            #region Add singleton
            services.AddSingleton<ProdutoValidator>();
            services.AddSingleton<ItemContabilProdutoValidator>();
            services.AddSingleton<ContaContabilProdutoValidator>();
            services.AddSingleton<ClasseValorProdutoValidator>();
            services.AddSingleton<TussValidator>();
            services.AddSingleton<EmpresaValidator>();
            services.AddSingleton<EntidadeValidator>();
            services.AddSingleton<ModuloVersaoValidator>();
            services.AddSingleton<TipoEntidadeVinculoValidator>();
            services.AddSingleton<TabelaServicoTipoEntidadeVinculoValidator>();
            services.AddSingleton<ClasssificacaoValidator>();
            services.AddSingleton<SaudeValidator>();
            services.AddSingleton<TipoUnidadeNegocioTipoEntidadeVinculoValidator>();
            services.AddSingleton<TipoUnidadeNegocioValidator>();
            services.AddSingleton<EnderecoUnidadeValidator>();
            services.AddSingleton<SaudeFiguraOdontogramaValidator>();
            services.AddSingleton<LinhaServicoValidator>();
            services.AddSingleton<FiguraOdontogramaValidator>();
            services.AddSingleton<ProdutoTipoFichaValidator>();
            services.AddSingleton<LazerValidator>();
            services.AddSingleton<ExameValidator>();
            services.AddSingleton<RiscoValidator>();
            services.AddSingleton<OdontogramaValidator>();
            services.AddSingleton<TipoFichaValidator>();
            services.AddSingleton<FuncaoValidator>();
            services.AddSingleton<AreaValidator>();
            services.AddSingleton<GrupoClassificacaoValidator>();
            services.AddSingleton<PlataformaValidator>();
            services.AddSingleton<ClassificacaoServicoValidator>();
            services.AddSingleton<UnidadeNegocioValidator>();
            services.AddSingleton<CodigoMunicipalValidator>();
            services.AddSingleton<ProdutoUnidadeNegocioValidator>();
            services.AddSingleton<EmpresaEntidadeVinculoValidator>();
            services.AddSingleton<CodigoMunicipalServicoCorporativoValidator>();
            services.AddSingleton<TipoRegiaoValidator>();
            services.AddSingleton<RegiaoUnidadeNegocioValidator>();
            services.AddSingleton<RegiaoValidator>();
            services.AddSingleton<Domain.Validations.Corporativo.Protheus.EmpresaValidator>();
            services.AddSingleton<EmpresaValidator>();
            services.AddSingleton<BairroValidator>();
            #endregion

            #region Add Scoped AppService
            services.AddScoped<IEmailAppService, EmailAppService>();
            services.AddScoped<ILoginAppService, LoginAppService>();           
            #endregion

            #region Add Scoped Service
            //services.AddScoped<ITipoRegiaoService, TipoRegiaoService>();            
            #endregion

            #region Add Scoped Repository
            //services.AddScoped<ITipoRegiaoRepository, TipoRegiaoRepositorio>();
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
                auth.AddPolicy("Bearer", new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme‌​)
                    .RequireAuthenticatedUser()
                    .Build());
            });
        }
    }
}
#region Includes
using Desafio.TecnicoLLip.Application.Interfaces;
using Desafio.TecnicoLLip.Application.Utils;
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
#endregion

namespace Desafio.TecnicoLLip.Application.Services
{
    public class LoginAppService : ILoginAppService
    {
        protected readonly Expression<Func<UsuarioViewModel, bool>> Instance = c => true;
        private readonly Security.Configuration.SigningConfigurations _signingConfigurations;
        private readonly Security.Configuration.TokenConfiguration _tokenConfiguration;
        private readonly IUsuarioAppService _usuarioAppService;
        public LoginAppService(
            Security.Configuration.SigningConfigurations signingConfigurations,
        Security.Configuration.TokenConfiguration tokenConfiguration,
        IUsuarioAppService usuarioAppService)
        {
            _signingConfigurations = signingConfigurations;
            _tokenConfiguration = tokenConfiguration;
            _usuarioAppService = usuarioAppService;

        }

        public Token ObterToken(UsuarioViewModel user)
        {
            if (user != null)
            {
                ClaimsIdentity identity = new ClaimsIdentity(new System.Security.Principal.GenericIdentity(user.Email, "Email"),
                    new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                         new Claim(JwtRegisteredClaimNames.UniqueName, user.Email)
                    });

                DateTime createDate = DateTime.Now;
                DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

                var handler = new JwtSecurityTokenHandler();
                string token = CreateToken(identity, createDate, expirationDate, handler);

                return SuccessObject(createDate, expirationDate, token);
            }
            else
            {
                return new Token
                {
                    Autenticated = false,
                    Message = "Falha na autenticação"
                };
            }
        }

        public Token ObterPorLogin(UserApi user)
        {
            bool credentialIsValid = false;

            if (user != null && !string.IsNullOrEmpty(user.Email))
            {
                var usr = BaseUsuarios.
                    Usuarios().
                    FirstOrDefault(u => u.Email == user.Email && u.Senha == user.Senha);

                credentialIsValid = (usr != null);
            }

            if (credentialIsValid)
            {
                ClaimsIdentity identity = new ClaimsIdentity(new System.Security.Principal.GenericIdentity(user.Email, "Email"),
                    new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                         new Claim(JwtRegisteredClaimNames.UniqueName, user.Email)
                    });

                DateTime createDate = DateTime.Now;
                DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

                var handler = new JwtSecurityTokenHandler();
                string token = CreateToken(identity, createDate, expirationDate, handler);

                return SuccessObject(createDate, expirationDate, token);
            }
            else
            {
                return new Token
                {
                    Autenticated = false,
                    Message = "Falha na autenticação"
                };
            }
        }

        public Token Login(string email, string senha)
        {
            var user = _usuarioAppService.ComFiltros("Email", true, a=> a.Email == email && a.Password == senha, 0, 0).Result.IfNotNull(on => on.FirstOrDefault());

            return ObterToken(user);
        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(
                new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
                {
                    Issuer = _tokenConfiguration.Issuer,
                    Audience = _tokenConfiguration.Audience,
                    SigningCredentials = _signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = createDate,
                    Expires = expirationDate
                });

            var token = handler.WriteToken(securityToken);
            return token;
        }

        private Token SuccessObject(DateTime createDate, DateTime expirationDate, string token)
        {
            return new Token
            {
                Autenticated = true,
                Created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                Expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                AccessToken = token,
                Message = "OK"
            };
        }

        public static class BaseUsuarios
        {
            public static IEnumerable<UserApi> Usuarios()
            {
                return new List<UserApi>
                {
                    new UserApi { Email = "Tllip12ab", Senha = "LlipRules" }
                };
            }
        }
    }
}
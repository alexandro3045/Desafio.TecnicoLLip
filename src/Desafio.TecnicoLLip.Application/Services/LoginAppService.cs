#region Includes
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
#endregion

namespace Desafio.TecnicoLLip.Application.Services
{
    public class LoginAppService : Interfaces.ILoginAppService
    {
        private readonly Security.Configuration.SigningConfigurations _signingConfigurations;
        private readonly Security.Configuration.TokenConfiguration _tokenConfiguration;

        public LoginAppService(
            Security.Configuration.SigningConfigurations signingConfigurations,
        Security.Configuration.TokenConfiguration tokenConfiguration)
        {
            _signingConfigurations = signingConfigurations;
            _tokenConfiguration = tokenConfiguration;
        }

        public Token ObterPorLogin(User user)
        {
            bool credentialIsValid = false;

            if (user != null && !string.IsNullOrEmpty(user.Login))
            {
                //TODO: implementar servidor de identidade
                var usr = BaseUsuarios.
                    Usuarios().
                    FirstOrDefault(u => u.Login == user.Login && u.AccessKey == user.AccessKey);

                credentialIsValid = (usr != null);
            }

            if (credentialIsValid)
            {
                ClaimsIdentity identity = new ClaimsIdentity(new System.Security.Principal.GenericIdentity(user.Login, "Login"),
                    new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                         new Claim(JwtRegisteredClaimNames.UniqueName, user.Login)
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

        // TODO: Analisar isso
        public static class BaseUsuarios
        {
            public static IEnumerable<User> Usuarios()
            {
                return new List<User>
                {
                    new User { Login = "Tllip12ab", AccessKey = "LlipRules" }
                };
            }
        }
    }
}
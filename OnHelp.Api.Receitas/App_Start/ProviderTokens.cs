using Microsoft.Owin.Security.OAuth;
using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Services;
using OnHelp.Api.Receitas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace OnHelp.Api.Receitas.App_Start
{
    public class ProviderTokens : OAuthAuthorizationServerProvider
    {
        private IUsuarioApplication _user;

        public ProviderTokens(IUsuarioApplication user)
        {
            _user = user;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var user = new UsuarioController(_user);

            if (user.Get(context.UserName, context.Password) != null)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("sub", context.UserName));
                identity.AddClaim(new Claim("role", "user"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("acesso inválido", "As credenciais do usuário não conferem....");
                return;
            }
        }

    }
}
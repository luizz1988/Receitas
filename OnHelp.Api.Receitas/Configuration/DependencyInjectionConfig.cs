using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.IoC;
using OnHelp.Api.Receitas.App_Start;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Web.Http;


namespace OnHelp.Api.Receitas.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureDependencyInjection(this IAppBuilder app, HttpConfiguration config)
        {
            var container = InitContainer(config);

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            IUsuarioApplication repository;
            using (AsyncScopedLifestyle.BeginScope(container))
            {
                repository = container.GetInstance<IUsuarioApplication>();
            }

            // ativando a geração do token
            AtivarGeracaoTokenAcesso(app, repository);
        }

        private static Container InitContainer(HttpConfiguration config)
        {
            var container = Container;

            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.RegisterRepositories();
            container.RegisterApplication();
            container.RegisterServices();

            container.RegisterWebApiControllers(config);

            container.Verify();

            return container;
        }

        public static Container Container { get; }
        static DependencyInjectionConfig()
        {
            Container = new Container();
        }

        private static void AtivarGeracaoTokenAcesso(IAppBuilder app, IUsuarioApplication inst)
        {
            var opcoesConfiguracaoToken = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                Provider = new ProviderTokens(inst)
            };
            app.UseOAuthAuthorizationServer(opcoesConfiguracaoToken);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
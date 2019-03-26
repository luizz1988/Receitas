using OnHelp.Api.IoC;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;


namespace OnHelp.Api.Receitas.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureDependencyInjection(this IAppBuilder app, HttpConfiguration config)
        {
            var container = InitContainer(config);

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
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
    }
}
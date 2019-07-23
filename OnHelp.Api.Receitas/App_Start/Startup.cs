using System.Web.Http;
using OnHelp.Api.Receitas.Configuration;
using Microsoft.Owin;
using Owin;
using OnHelp.Api.Receitas.App_Start;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using System;
using OnHelp.Api.Domain.Contracts.Application;

[assembly: OwinStartup(typeof(Startup))]

namespace OnHelp.Api.Receitas.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

          

            app.UseWebApi(config);
            app.RegisterWebApi(config);
            app.RegisterMediaTypeFormatter(config);
            app.ConfigureDependencyInjection(config);

            // ativando cors
            app.UseCors(CorsOptions.AllowAll);

        }

       
    }
}
using OnHelp.Api.Receitas.Serializer;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnHelp.Api.Receitas.Configuration
{
    public static class MediaTypeFormatterConfig
    {
        public static void RegisterMediaTypeFormatter(this IAppBuilder app, HttpConfiguration config)
        {
            var formatter = config.Formatters.JsonFormatter;

            if (formatter != null)
            {
                config.Formatters.Remove(formatter);
            }

            config.Formatters.Insert(0, new ServiceStackJsonMediaTypeFormatter());
        }
    }
}
using OnHelp.Api.Application;
using OnHelp.Api.Domain.Contracts.Application;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.IoC
{
    public static class ApplicationContainer
    {
        public static void RegisterApplication(this Container container)
        {
            container.Register<IReceitaApplication, ReceitaApplication>(Lifestyle.Scoped);
            

        }
    }
}

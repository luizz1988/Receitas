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
            container.Register<ICategoriaApplication, CategoriaApplication>(Lifestyle.Scoped);
            container.Register<IUnidadeApplication, UnidadeApplication>(Lifestyle.Scoped);
            container.Register<IPessoaApplication, PessoaApplication>(Lifestyle.Scoped);
            container.Register<IUsuarioApplication, UsuarioApplication>(Lifestyle.Scoped);


        }
    }
}

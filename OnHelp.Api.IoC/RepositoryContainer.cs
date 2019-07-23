using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.IoC
{
    public static class RepositoryContainer
    {
        public static void RegisterRepositories(this Container container)
        {

            container.Register<IReceitaRepository, ReceitaRepository>(Lifestyle.Scoped);
            container.Register<ICategoriaRepository, CategoriaRepository>(Lifestyle.Scoped);
            container.Register<IUnidadeRepository, UnidadeRepository>(Lifestyle.Scoped);
            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);


        }
    }
}

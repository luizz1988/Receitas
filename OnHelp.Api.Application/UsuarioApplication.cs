using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using OnHelp.Api.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioApplication(IUsuarioRepository repository)
        {
            this._repository = repository;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(string login, string senha)
        {
            var service = new UsuarioService(_repository);
            return service.GetAcess(login, senha);
        }

        public List<Usuario> GetAll()
        {
            var service = new UsuarioService(_repository);
            return service.GetAll();
        }

        public Usuario GetById(int id)
        {
            var service = new UsuarioService(_repository);
            return service.GetById(id);
        }

        public void Register(Usuario user)
        {
            var service = new UsuarioService(_repository);
            service.Registre(user);
        }

        public void Update(Usuario entity)
        {
            var service = new UsuarioService(_repository);
            service.Update(entity);
        }
      
    }
}

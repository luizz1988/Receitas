using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;

        }

        public List<Usuario> GetAll()
        {
            var result = _repository.GetAll();

            return result;

        }

        public Usuario GetById(int id)
        {
            var result = _repository.GetById(id);

            return result;
        }

        public Usuario GetAcess(string login, string senha)
        {
            var result = _repository.GetByCriteria(e => e.Login == login && e.Senha == senha).FirstOrDefault();

            return result;
        }


        public void Registre(Usuario item)
        {
            _repository.AddOrUpdate(item);
            _repository.Save();
        }

        public void Update(Usuario entity)
        {
            try
            {

                _repository.AddOrUpdate(entity);
                _repository.Save();

            }
            catch (Exception)
            {
                throw;
            }


        }

    }
}

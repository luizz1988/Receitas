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
  public  class PessoaApplication : IPessoaApplication
    {
        private readonly IPessoaRepository _repository;

        public PessoaApplication(IPessoaRepository repository)
        {
            this._repository = repository;

        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> Get(string name)
        {
            var service = new PessoaService(_repository);
            return service.GetByName(name).ToList();
        }

        public List<Pessoa> GetAll()
        {
            var service = new PessoaService(_repository);
            return service.GetAll();
        }

        public Pessoa GetById(int id)
        {
            var service = new PessoaService(_repository);
            return service.GetById(id);
        }

        public void Register(Pessoa user)
        {
            var service = new PessoaService(_repository);
            service.Registre(user);
        }

        public void Update(Pessoa entity)
        {
            var service = new PessoaService(_repository);
            service.Update(entity);
        }

    }
}

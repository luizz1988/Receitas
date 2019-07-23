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
    public class UnidadeApplication : IUnidadeApplication
    {
        private readonly IUnidadeRepository _unidadeRepository;

        public UnidadeApplication(IUnidadeRepository unidadeRepository)
        {
            this._unidadeRepository = unidadeRepository;
           
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Unidade> Get(string name)
        {
            var service = new UnidadeService(_unidadeRepository);
            return service.GetByName(name).ToList();
        }

        public List<Unidade> GetAll()
        {
            var service = new UnidadeService(_unidadeRepository);
            return service.GetAll();
        }

        public Unidade GetById(int id)
        {
            var service = new UnidadeService(_unidadeRepository);
            return service.GetById(id);
        }

        public void Register(Unidade user)
        {
            var service = new UnidadeService(_unidadeRepository);
            service.Registre(user);
        }

        public void Update(Unidade entity)
        {
            var service = new UnidadeService(_unidadeRepository);
            service.Update(entity);
        }
    }
}

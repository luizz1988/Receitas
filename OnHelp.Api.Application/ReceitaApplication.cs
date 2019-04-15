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
    public class ReceitaApplication : IReceitaApplication
    {
        #region : Constructor

        private readonly IReceitaRepository _receitaRepository;

        public ReceitaApplication(IReceitaRepository receitaRepository)
        {
            this._receitaRepository = receitaRepository;
        }

        public void Delete(Receita entity)
        {
            var service = new ReceitaService(_receitaRepository);
            service.Delete(entity);
        }
        #endregion

        public List<Receita> Get(string title)
        {
            var service = new ReceitaService(_receitaRepository);
            return service.GetTitle(title).ToList();
        }

        public List<Receita> GetAll()
        {
            var service = new ReceitaService(_receitaRepository);
            return service.GetAll();
        }

        public Receita GetById(int id)
        {
            var service = new ReceitaService(_receitaRepository);
            return service.GetById(id);
        }

        public void Register(Receita user)
        {
            var service = new ReceitaService(_receitaRepository);
            service.Registre(user);
        }

        public void Update(Receita entity)
        {
            var service = new ReceitaService(_receitaRepository);
            service.Update(entity);
        }
    }
}

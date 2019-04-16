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
        private readonly ICategoriaRepository _categoriaRepository;

        public ReceitaApplication(IReceitaRepository receitaRepository, ICategoriaRepository categoriaRepository)
        {
            this._receitaRepository = receitaRepository;
            _categoriaRepository = categoriaRepository;
        }

        public void Delete(int id)
        {
            var service = new ReceitaService(_receitaRepository, _categoriaRepository);
            service.Delete(id);
        }
        #endregion

        public List<Receita> Get(string title)
        {
            var service = new ReceitaService(_receitaRepository, _categoriaRepository);
            return service.GetTitle(title).ToList();
        }

        public List<Receita> GetAll()
        {
            var service = new ReceitaService(_receitaRepository, _categoriaRepository);
            return service.GetAll();
        }

        public Receita GetById(int id)
        {
            var service = new ReceitaService(_receitaRepository, _categoriaRepository);
            return service.GetById(id);
        }

        public void Register(Receita user)
        {
            var service = new ReceitaService(_receitaRepository, _categoriaRepository);
            service.Registre(user);
        }

        public void Update(Receita entity)
        {
            var service = new ReceitaService(_receitaRepository, _categoriaRepository);
            service.Update(entity);
        }
    }
}

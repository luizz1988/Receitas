using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnHelp.Api.Domain.Model;
using OnHelp.Api.Domain.Services;

namespace OnHelp.Api.Application
{
   public class CategoriaApplication: ICategoriaApplication
    {
        #region : Constructor

        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaApplication(ICategoriaRepository categoriaRepository)
        {
            this._categoriaRepository = categoriaRepository;
        }

        public void Delete(int id)
        {
            var service = new CategoriaService(_categoriaRepository);
            service.Delete(id);
        }

        public List<Categoria> Get(string title)
        {
            var service = new CategoriaService(_categoriaRepository);
            return service.GetTitle(title).ToList();
        }

        public List<Categoria> GetAll()
        {
            var service = new CategoriaService(_categoriaRepository);
            return service.GetAll();
        }

        public Categoria GetById(int id)
        {
            var service = new CategoriaService(_categoriaRepository);
            return service.GetById(id);
        }

        public void Register(Categoria item)
        {
            var service = new CategoriaService(_categoriaRepository);
            service.Registre(item);
        }

        public void Update(Categoria entity)
        {
            var service = new CategoriaService(_categoriaRepository);
            service.Update(entity);
        }
        #endregion


    }
}

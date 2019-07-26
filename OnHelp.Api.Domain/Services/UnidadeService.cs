using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Services
{
   public class UnidadeService
    {
        
        private readonly IUnidadeRepository _unidadeRepository;
        public UnidadeService(IUnidadeRepository unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
           
        }


        public List<Unidade> GetAll()
        {
            var result = _unidadeRepository.GetAll();

            return result;

        }

        public Unidade GetById(int id)
        {
            var result = _unidadeRepository.GetById(id);

            return result;
        }

        public IEnumerable<Unidade> GetByName(string name)
        {
            var result = _unidadeRepository.GetByCriteria(e => e.Name.Contains(name));

            return result;
        }


        public void Registre(Unidade item)
        {
            _unidadeRepository.AddOrUpdate(item);
            _unidadeRepository.Save();
        }

        public void Update(Unidade entity)
        {
            try
            {

                _unidadeRepository.AddOrUpdate(entity);
                _unidadeRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }


        }

        public void Delete(int id)
        {
            try
            {
                var result = _unidadeRepository.GetById(id);
                _unidadeRepository.Delete(result);
                _unidadeRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }


        }


    }
}

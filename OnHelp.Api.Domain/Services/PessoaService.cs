using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Services
{
   public class PessoaService
    {
        private readonly IPessoaRepository _repository;
        public PessoaService(IPessoaRepository repository)
        {
            _repository = repository;

        }

        public List<Pessoa> GetAll()
        {
            var result = _repository.GetAll();

            return result;

        }

        public Pessoa GetById(int id)
        {
            var result = _repository.GetById(id);

            return result;
        }

        public IEnumerable<Pessoa> GetByName(string name)
        {
            var result = _repository.GetByCriteria(e => e.Name.Contains(name));

            return result;
        }


        public void Registre(Pessoa item)
        {
            _repository.AddOrUpdate(item);
            _repository.Save();
        }

        public void Update(Pessoa entity)
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

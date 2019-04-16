using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using OnHelp.Api.Domain.Model.ExceptionCustom;
using OnHelp.Api.Domain.Services.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Services
{

    public class ReceitaService
    {

        private readonly IReceitaRepository _receitaRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        public ReceitaService(IReceitaRepository receitaRepository, ICategoriaRepository categoriaRepository)
        {
            _receitaRepository = receitaRepository;
            _categoriaRepository = categoriaRepository;
        }


        public void Registre(Receita item)
        {
            //Validacao
            FluentValidation.Results.ValidationResult result = new ReceitaValidator().Validate(item);

            if (!result.IsValid)
                throw new CustomException(result);

            item.Categoria = _categoriaRepository.GetById(item.Categoria.Id);

            _receitaRepository.AddOrUpdate(item);
            _receitaRepository.Save();
        }

        public IEnumerable<Receita> GetTitle(string title)
        {
            var result = _receitaRepository.GetByCriteria(e => e.Title.Contains(title));

            return result;
        }

        public List<Receita> GetAll()
        {
            var result = _receitaRepository.GetAllReceita();

            return result;

        }

        public void Update(Receita entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    throw new CustomException("Receita Inexistente!");
                }

                _receitaRepository.AddOrUpdate(entity);
                _receitaRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }


        }

        public void Delete(int id)
        {

            if (id == 0)
            {
                throw new CustomException("Receita Inexistente!");
            }

            var delet = _receitaRepository.GetById(id);

            _receitaRepository.Delete(delet);
            _receitaRepository.Save();


        }

        public Receita GetById(int id)
        {
            var result = _receitaRepository.GetById(id);

            return result;
        }

    }
}

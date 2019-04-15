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
    public class CategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void Registre(Categoria item)
        {


            //Validacao
            FluentValidation.Results.ValidationResult result = new CategoriaValidator().Validate(item);

            if (!result.IsValid)
                throw new CustomException(result);

            _categoriaRepository.AddOrUpdate(item);
            _categoriaRepository.Save();
        }

        public IEnumerable<Categoria> GetTitle(string title)
        {
            var result = _categoriaRepository.GetByCriteria(e => e.Title.Contains(title));

            return result;
        }

        public List<Categoria> GetAll()
        {
            var result = _categoriaRepository.GetAll();

            return result;

        }

        public void Update(Categoria entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    throw new CustomException("Categoria Inexistente!");
                }

                _categoriaRepository.AddOrUpdate(entity);
                _categoriaRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }


        }

        public void Delete(Categoria entity)
        {

            if (entity.Id == 0)
            {
                throw new CustomException("Categoria Inexistente!");
            }

            var delet = _categoriaRepository.GetById(entity.Id);

            _categoriaRepository.Delete(delet);
            _categoriaRepository.Save();

            
        }

        public Categoria GetById(int id)
        {
            var result = _categoriaRepository.GetById(id);

            return result;
        }


    }
}

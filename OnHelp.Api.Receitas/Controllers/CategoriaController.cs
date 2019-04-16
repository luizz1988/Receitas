using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnHelp.Api.Receitas.Controllers
{
    [RoutePrefix("API/categoria")]
    public class CategoriaController : ApiController
    {
        private readonly ICategoriaApplication _categoriaApplication;

        public CategoriaController(ICategoriaApplication categoriaApplication)
        {
            _categoriaApplication = categoriaApplication;
        }
        
        [HttpGet]
        public IHttpActionResult Get([FromUri] string title)
        {
            try
            {
                var result = _categoriaApplication.Get(title);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da categoria!"));
            }



        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = _categoriaApplication.GetAll();

                return Ok(result);

            }
            catch (Exception ex)
            {

                return InternalServerError(new Exception("Erro na consulta da categoria!"));
            }



        }

        [HttpGet]
        public IHttpActionResult GetById([FromUri] int id)
        {
            try
            {
                var result = _categoriaApplication.GetById(id);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da Categoria!"));
            }



        }

        [HttpPost]
        public IHttpActionResult Register([FromBody]Categoria entity)
        {
            try
            {

                _categoriaApplication.Register(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        public IHttpActionResult Update([FromBody]Categoria entity)
        {
            try
            {

                _categoriaApplication.Update(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromUri]int id)
        {
            try
            {

                _categoriaApplication.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


    }
}

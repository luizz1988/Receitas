using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnHelp.Api.Receitas.Controllers
{

    [RoutePrefix("API/unidades")]
    public class UnidadesController : ApiController
    {
        private readonly IUnidadeApplication _unidadeApplication;

        public UnidadesController(IUnidadeApplication unidadeApplication)
        {
            _unidadeApplication = unidadeApplication;
        }


        [HttpGet]
        public IHttpActionResult Get([FromUri] string title)
        {
            try
            {
                var result = _unidadeApplication.Get(title);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }

        [HttpPost]
        public IHttpActionResult Register([FromBody]Unidade entity)
        {
            try
            {

                _unidadeApplication.Register(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = _unidadeApplication.GetAll();

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }

        [HttpGet]
        public IHttpActionResult GetById([FromUri] int id)
        {
            try
            {
                var result = _unidadeApplication.GetById(id);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }

        
        [HttpPut]
        public IHttpActionResult Update([FromBody]Unidade entity)
        {
            try
            {

                _unidadeApplication.Update(entity);

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

                _unidadeApplication.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
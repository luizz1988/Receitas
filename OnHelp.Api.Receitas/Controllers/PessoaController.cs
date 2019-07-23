using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnHelp.Api.Receitas.Controllers
{
    [RoutePrefix("API/pessoas")]
    public class PessoaController : ApiController
    {
        private readonly IPessoaApplication _application;

        public PessoaController(IPessoaApplication application)
        {
            _application = application;
        }


        [HttpGet]
        public IHttpActionResult Get([FromUri] string name)
        {
            try
            {
                var result = _application.Get(name);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }

        [HttpPost]
        public IHttpActionResult Register([FromBody]Pessoa entity)
        {
            try
            {

                _application.Register(entity);

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
                var result = _application.GetAll();

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
                var result = _application.GetById(id);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }


        [HttpPut]
        public IHttpActionResult Update([FromBody]Pessoa entity)
        {
            try
            {

                _application.Update(entity);

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

                _application.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
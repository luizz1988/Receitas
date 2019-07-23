using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnHelp.Api.Receitas.Controllers
{
    [RoutePrefix("API/usuario")]
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioApplication _application;

        public UsuarioController(IUsuarioApplication application)
        {
            _application = application;
        }
        
        [HttpGet]
        public IHttpActionResult Get([FromUri] string usuario, [FromUri] string senha)
        {
            try
            {
                var result = _application.Get(usuario, senha);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Register([FromBody]Usuario entity)
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

        [Authorize]
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

                return InternalServerError(new Exception("Erro na consulta!"));
            }



        }

        [Authorize]
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

                return InternalServerError(new Exception("Erro na consulta!"));
            }



        }

        [Authorize]
        [HttpPut]
        public IHttpActionResult Update([FromBody]Usuario entity)
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

        [Authorize]
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
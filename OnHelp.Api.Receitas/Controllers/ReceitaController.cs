using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using OnHelp.Api.Domain.Model.ExceptionCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnHelp.Api.Receitas.Controllers
{
 
    [RoutePrefix("API/receita")]
    public class ReceitaController : ApiController
    {
        private readonly IReceitaApplication _receitaApplication;

        public ReceitaController(IReceitaApplication receitaApplication)
        {
            _receitaApplication = receitaApplication;
        }


        [HttpGet]
        public IHttpActionResult Get([FromUri] string title)
        {
            try
            {
                var result = _receitaApplication.Get(title);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }
           

           
        }

        [HttpPost]
        public IHttpActionResult Register([FromBody]Receita receita)
        {
            try
            {

                _receitaApplication.Register(receita);

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
                var result = _receitaApplication.GetAll();

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
                var result = _receitaApplication.GetById(id);

                return Ok(result);

            }
            catch (Exception)
            {

                return InternalServerError(new Exception("Erro na consulta da receita!"));
            }



        }


        [HttpPut]
        public IHttpActionResult Update([FromBody]Receita entity)
        {
            try
            {

                _receitaApplication.Update(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromBody]Receita entity)
        {
            try
            {

                _receitaApplication.Delete(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}

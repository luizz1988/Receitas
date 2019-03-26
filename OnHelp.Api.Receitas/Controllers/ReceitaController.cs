using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnHelp.Api.Receitas.Controllers
{
    [EnableCors(origins: "http://localhost:8888", headers: "*", methods: "*")]
    [RoutePrefix("API/ocorrencia")]
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
    }
}

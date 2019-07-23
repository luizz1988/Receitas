using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Services
{
   public class AcessController
    {

        private readonly IUsuarioApplication _application;

        public AcessController(IUsuarioApplication application)
        {
            _application = application;
        }

        public Usuario Get(string usuario,  string senha)
        {
            try
            {
                var result = _application.Get(usuario, senha);

                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

    }
}

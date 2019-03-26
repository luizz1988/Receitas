using OnHelp.Api.Domain.Contracts.Application;
using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using OnHelp.Api.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Application
{
    public class ReceitaApplication : IReceitaApplication
    {
        #region : Constructor

        private readonly IReceitaRepository _receitaRepository;

        public ReceitaApplication(IReceitaRepository receitaRepository)
        {
            this._receitaRepository = receitaRepository;
        }
        #endregion

        public Receita Get(string title)
        {
            var service = new ReceitaService(_receitaRepository);
            return service.GetTitle(title).FirstOrDefault();
        }

        public Receita GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Register(Receita user)
        {
            var service = new ReceitaService(_receitaRepository);
            service.Registre(user);
        }
    }
}

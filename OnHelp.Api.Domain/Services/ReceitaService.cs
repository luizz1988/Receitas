using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
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
        public ReceitaService(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }


        public void Registre(Receita item)
        {

            //Validacao
            //Efetuar Validação Usando Fluente

            //Criar uma execption customizada


            _receitaRepository.AddOrUpdate(item);
            _receitaRepository.Save();
        }

        public IEnumerable<Receita> GetTitle(string title)
        {
            var result = _receitaRepository.GetByCriteria(e => e.Title == title);

            return result;
        }

    }
}

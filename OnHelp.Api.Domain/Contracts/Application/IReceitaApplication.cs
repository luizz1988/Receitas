using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Contracts.Application
{
    public interface IReceitaApplication
    {
        Receita GetById(int id);
        void Register(Receita user);
        List<Receita> Get(string title);
        List<Receita> GetAll();
        void Update(Receita entity);
        void Delete(int id);
    }
}

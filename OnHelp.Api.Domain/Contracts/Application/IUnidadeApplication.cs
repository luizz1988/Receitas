using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Contracts.Application
{
   public interface IUnidadeApplication
    {
        Unidade GetById(int id);
        void Register(Unidade user);
        List<Unidade> Get(string title);
        List<Unidade> GetAll();
        void Update(Unidade entity);
        void Delete(int id);

    }
}

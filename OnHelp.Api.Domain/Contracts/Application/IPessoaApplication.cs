using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Contracts.Application
{
    public interface IPessoaApplication
    {
        Pessoa GetById(int id);
        void Register(Pessoa user);
        List<Pessoa> Get(string name);
        List<Pessoa> GetAll();
        void Update(Pessoa entity);
        void Delete(int id);

    }
}

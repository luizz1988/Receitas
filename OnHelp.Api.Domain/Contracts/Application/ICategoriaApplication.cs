using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Contracts.Application
{
    public interface ICategoriaApplication
    {
        Categoria GetById(int id);
        void Register(Categoria entity);
        List<Categoria> Get(string title);
        List<Categoria> GetAll();
        void Update(Categoria entity);
        void Delete(Categoria entity);
    }
}

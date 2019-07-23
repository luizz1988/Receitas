using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Contracts.Application
{
    public interface IUsuarioApplication
    {
        Usuario GetById(int id);
        void Register(Usuario user);
        Usuario Get(string usuario, string senha);
        List<Usuario> GetAll();
        void Update(Usuario entity);
        void Delete(int id);
    }
}

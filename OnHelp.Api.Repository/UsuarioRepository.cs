using OnHelp.Api.Domain.Contracts.Repositories;
using OnHelp.Api.Domain.Model;
using OnHelp.Api.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Repository
{
    public class UsuarioRepository : DataAccessBase<Usuario>, IUsuarioRepository
    {
    }
}

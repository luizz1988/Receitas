using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Model
{
   public class Usuario : EntityBase
    {

        [Required, MaxLength(50)]
        public string Login { get; set; }

        [Required, MaxLength(50)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        //Foreign key for Standard
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }


    }
}

using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Model
{
    public class Pessoa : EntityBase
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50), EmailAddress]
        public string Email { get; set; }

    }
}

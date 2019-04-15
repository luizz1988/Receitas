using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Model
{
  public  class Categoria : EntityBase
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }

    }
}

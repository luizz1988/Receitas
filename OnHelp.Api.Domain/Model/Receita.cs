using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Model
{
    public class Receita : EntityBase
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }

        [Required, MaxLength(800)]
        public string Ingredients { get; set; }

        [Required, MaxLength(1000)]
        public string MethodOfPreparation { get; set; }

        public Byte[] Image { get; set; }

        public string Tags { get; set; }

        [Required]
        public virtual Categoria Categoria { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnHelp.Api.Receitas.Site.Models
{
    public class Receita
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public string MethodOfPreparation { get; set; }

        public Byte[] Image { get; set; }

        public string Tags { get; set; }

       public Categoria Categoria { get; set; }
    }
}
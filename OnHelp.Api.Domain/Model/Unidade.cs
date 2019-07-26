using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Model
{
   public class Unidade : EntityBase
    {

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int LotacaoTotal { get; set; }

        [Required]
        public int LotacaoAtual { get; set; }

        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cidade { get; set; }
    }
}

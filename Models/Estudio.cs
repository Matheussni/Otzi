using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    [Table("Estudio")]
    public class Estudio
    {
        [Key]
        public int EstudioId { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Display(Name = "CEP")]
        public Endereco Endereco { get; set; }
    }
}
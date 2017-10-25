using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    [Table("Tatuagem")]
    public class Tatuagem
    {
        [Key]
        public int TatuagemId { get; set; }

        public Tatuador Tatuador { get; set; }

        public string Imagem { get; set; }

        public Boolean Disponibilidade { get; set; }

        public string Tamanho { get; set; }

        public string Preco { get; set; }

        public int Curtidas { get; set; }
    }
}
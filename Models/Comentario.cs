using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    [Table("Comentario")]
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }

        public Usuario Usuario { get; set; }

        public Tatuagem Tatuagem { get; set; }

        public string Conteudo { get; set; }

        public DateTime Data { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    public class Cliente : Usuario
    {
        [Display(Name = "CPF")]
        private string cpf;

        public string Cpf { get => cpf; set => cpf = value; }
    }
}
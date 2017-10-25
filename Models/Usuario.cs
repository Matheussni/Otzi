using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
                    
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmação da Senha")]
        [Compare("Senha", ErrorMessage = "Os campos não coincicem!")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string PasswordConfirmation { get; set; }

        [Display(Name = "CEP")]
        public Endereco Endereco;      
    }
}
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    public class Tatuador : Usuario
    {
   
        public string CNPJ { get; set; }
        
        public Estudio Estudio { get; set; }

        public Endereco EnderecoDeTrabalho { get; set; }

        public int Permissao { get; set; }
    }
}
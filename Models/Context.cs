using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Otzi.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Estudios> Estudios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Tatuagens> Tatuagens { get; set; }

    }
}

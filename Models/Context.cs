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
    }
}

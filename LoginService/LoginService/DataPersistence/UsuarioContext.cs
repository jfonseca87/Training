using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LoginService.DataPersistence
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() 
            : base("name=UsuarioContext") 
        {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class PersonaContext : DbContext
    {
        public PersonaContext()
            : base("PersonaContext")
        { }

        public DbSet<Persona> Persona { get; set; }
    }
}
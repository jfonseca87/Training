using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ET
{
    public class CRUDContext : DbContext
    {
        public CRUDContext() : base("CRUDContext") 
        { }

        public DbSet<Persona> Persona { get; set; }
    }
}

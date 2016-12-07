namespace WcfPersona.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PersonaContext : DbContext
    {
        public PersonaContext()
            : base("name=PersonaContext")
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(e => e.DocPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.NomPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.ApePersona)
                .IsUnicode(false);
        }
    }
}

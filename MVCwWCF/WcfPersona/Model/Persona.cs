namespace WcfPersona.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Persona")]
    public partial class Persona
    {
        [Key]
        public int IdPersona { get; set; }

        [Required(ErrorMessage="Debe ingresar el documento de la persona")]
        [StringLength(15)]
        public string DocPersona { get; set; }

        [Required(ErrorMessage="Debe ingresar los nombres de la persona")]
        [StringLength(50)]
        public string NomPersona { get; set; }

        [Required(ErrorMessage="Debe ingresar los apellidos de la persona")]
        [StringLength(50)]
        public string ApePersona { get; set; }

        public int Edad { get; set; }

        public List<Persona> listarPersonas()
        {
            List<Persona> lstPersonas = new List<Persona>();

            try
            {
                using (var context = new PersonaContext())
                {
                    lstPersonas = context.Persona.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstPersonas;
        }

        public Persona traePersona(int id)
        {
            Persona persona = new Persona();

            try
            {
                using (var context = new PersonaContext())
                {
                    persona = context.Persona.Where(p => p.IdPersona == id).First();
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message) ;
            }

            return persona;
        }

        public bool creaPersona()
        {
            try
            {
                using(var context = new PersonaContext())
                {
                    context.Entry(this).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = new Exception(ex.Message).ToString();
                return false;
            }
        }

        public bool editaPersona()
        {
            try
            {
                using (var context = new PersonaContext())
                {
                    context.Entry(this).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = new Exception(ex.Message).ToString();
                return false;
            }
        }
    }
}

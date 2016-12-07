using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaService.Data
{
    public class OData
    {
        public List<Persona> listarPersonas()
        {
            try
            {
                using (var context = new PRUEBASEntities())
                {
                    return context.Persona.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Persona traePersona(int id)
        {
            try
            {
                using (var context = new PRUEBASEntities())
                {
                    return context.Persona.Where(p => p.IdPersona == id).First();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool nuevaPersona(Persona persona)
        {
            try
            {
                using (var context = new PRUEBASEntities())
                {
                    context.Entry(persona).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
                return false;
            }
        }

        public bool editaPersona(Persona persona)
        {
            try
            {
                using (var context = new PRUEBASEntities())
                {
                    context.Entry(this).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
                return false;
            }
        }
    }
}
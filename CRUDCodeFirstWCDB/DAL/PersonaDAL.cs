using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using ET;

namespace DAL
{
    public class PersonaDAL
    {
        public List<Persona> listarPersonas()
        {
            List<Persona> lstPersonas = new List<Persona>();

            try
            {
                using (var context = new CRUDContext())
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
                using (var context = new CRUDContext())
                {
                    persona = context.Persona.Where(p => p.IdPersona == id).First();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return persona;
        }

        public void creaPersona(Persona persona)
        {
            try
            {
                using (var context = new CRUDContext())
                {
                    context.Entry(persona).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void editaPersona(Persona persona)
        {
            try
            {
                using (var context = new CRUDContext())
                {
                    context.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

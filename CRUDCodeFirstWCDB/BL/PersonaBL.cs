using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ET;
using DAL;

namespace BL
{
    public class PersonaBL
    {
        PersonaDAL personD = new PersonaDAL();

        public List<Persona> Listar()
        {
            return personD.listarPersonas();
        }

        public Persona traePersona(int id)
        {
            return personD.traePersona(id);
        }

        public void nuevaPersona(Persona persona)
        {
            personD.creaPersona(persona);
        }

        public void editaPersona(Persona persona)
        {
            personD.editaPersona(persona);
        }
    }
}

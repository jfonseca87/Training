using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfPersona.Model;

namespace WcfPersona
{
    public class PersonaData : IPersonaData
    {
        Persona persona = new Persona();

        public List<Persona> listar()
        {
            return persona.listarPersonas();
        }

        public Persona traePersona(int id)
        {
            return persona.traePersona(id);
        }

        public bool creaPersona(Persona persona)
        {
            return persona.creaPersona();
        }

        public bool editaPersona(Persona persona)
        {
            return persona.editaPersona();
        }
    }
}

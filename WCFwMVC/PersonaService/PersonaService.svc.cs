using PersonaService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PersonaService
{
    public class PersonaService : IPersonaService
    {
        OData oPersona = new OData(); 

        public List<Persona> listarPersonas()
        {
            return oPersona.listarPersonas();
        }

        public Persona traePersona(int id)
        {
            return oPersona.traePersona(id);
        }

        public bool nuevaPersona(Persona persona)
        {
            return oPersona.nuevaPersona(persona);
        }

        public bool editaPersona(Persona persona)
        {
            return oPersona.editaPersona(persona);
        }
    }
}

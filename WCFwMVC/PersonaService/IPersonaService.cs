using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ComponentModel.DataAnnotations;
using PersonaService.Data;


namespace PersonaService
{
    [ServiceContract]
    public interface IPersonaService
    {
        [OperationContract]
        List<Persona> listarPersonas();

        [OperationContract]
        Persona traePersona(int id);

        [OperationContract]
        bool nuevaPersona(Persona persona);

        [OperationContract]
        bool editaPersona(Persona persona);
    }
}

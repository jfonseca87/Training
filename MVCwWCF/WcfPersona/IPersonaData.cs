using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfPersona.Model;

namespace WcfPersona
{
    [ServiceContract]
    public interface IPersonaData
    {
        [OperationContract]
        List<Persona> listar();

        [OperationContract]
        Persona traePersona(int id);

        [OperationContract]
        bool creaPersona(Persona persona);

        [OperationContract]
        bool editaPersona(Persona persona);
    }
}

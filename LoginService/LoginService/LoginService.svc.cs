using LoginService.DataPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoginService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoginService.svc or LoginService.svc.cs at the Solution Explorer and start debugging.
    public class LoginService : ILoginService
    {
        DALUsuario usuario = new DALUsuario();

        public DataPersistence.Usuario getUsuario(string user, string password)
        {
            return usuario.GetUsuario(user, password);
        }
    }
}

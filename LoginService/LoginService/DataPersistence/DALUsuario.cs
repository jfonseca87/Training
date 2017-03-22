using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace LoginService.DataPersistence
{
    public class DALUsuario
    {

        UsuarioContext userContext = new UsuarioContext();
        Usuario usuario = new Usuario();

        public Usuario GetUsuario(string user, string password)
        {
            try 
	        {	        
		        usuario = (from u in userContext.Usuarios
                          where u.NUsuario == user && u.Password == password
                          select u).First();

                return usuario;
	        }
	        catch (SqlException ex)
	        {
		        throw new Exception(ex.Message);
	        }
                
        }
    }
}
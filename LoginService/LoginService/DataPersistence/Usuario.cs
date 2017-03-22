using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginService.DataPersistence
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string NUsuario { get; set; }
        public string Password { get; set; }
        public int Activo { get; set; }
        public string KeYValue { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCwWCF.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string DocPersona { get; set; }
        public string NomPersona { get; set; }
        public string ApePersona { get; set; }
        public int Edad { get; set; }
    }
}
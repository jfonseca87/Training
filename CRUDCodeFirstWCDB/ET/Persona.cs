using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ET
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        public string DocPersona { get; set; }
        public string NomPersona { get; set; }
        public string ApePersona { get; set; }
        public int Edad { get; set; }
    }
}

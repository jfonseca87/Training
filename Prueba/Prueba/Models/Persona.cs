using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Prueba.Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }

        [Required]
        public string DocPersona { get; set; }

        [Required]
        public string NomPersona { get; set; }

        [Required]
        public string ApePersona { get; set; }

        public int Edad { get; set; }

        public List<Persona> listarPersonas()
        {
            List<Persona> lstPersona = new List<Persona>();

            try 
	        {
	            using(var context = new PersonaContext())
                {
                    lstPersona = context.Persona.ToList();
                } 
	        }
	        catch (Exception ex)
	        {
		        throw new Exception(ex.Message);
	        }

            return lstPersona;
        }
    }
}
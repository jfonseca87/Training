using Cliente.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cliente.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            PersonaServiceClient objService = new PersonaServiceClient(); 

            return View( objService.listarPersonas() );
        }
    }
}
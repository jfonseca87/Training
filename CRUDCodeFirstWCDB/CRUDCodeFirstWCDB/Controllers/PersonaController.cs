using ET;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CRUDCodeFirstWCDB.Controllers
{
    public class PersonaController : Controller
    {

        PersonaBL personaBL = new PersonaBL();

        public ActionResult Index()
        {
            return View( personaBL.Listar() );
        }

        public ActionResult nuevaPersona()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevaPersona(Persona persona)
        {
            if (ModelState.IsValid == true)
            {
                personaBL.nuevaPersona(persona);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult editaPersona(int id)
        {
            return View( personaBL.traePersona(id) );
        }

        [HttpPost]
        public ActionResult editaPersona(Persona persona)
        {
            if (ModelState.IsValid == true)
            {
                personaBL.editaPersona(persona);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}

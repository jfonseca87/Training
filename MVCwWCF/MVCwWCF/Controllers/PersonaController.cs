using MVCwWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwWCF.Controllers
{
    public class PersonaController : Controller
    {
        WCFPersonaReference.PersonaDataClient objWCFPersona = new WCFPersonaReference.PersonaDataClient();

        public ActionResult Index()
        {
            ViewBag.Lista = objWCFPersona.listar();
            return View();
        }

        public ActionResult nuevaPersona()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevaPersona(WCFPersonaReference.Persona persona)
        {
            if (ModelState.IsValid == true)
            {
                bool respuesta = objWCFPersona.creaPersona(persona);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult editaPersona(int id)
        {
            return View( objWCFPersona.traePersona(id) );
        }

        [HttpPost]
        public ActionResult editaPersona(WCFPersonaReference.Persona persona)
        {
            if (ModelState.IsValid == true)
            {
                bool respuesta = objWCFPersona.editaPersona(persona);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}

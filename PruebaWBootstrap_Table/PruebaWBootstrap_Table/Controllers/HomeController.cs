using PruebaWBootstrap_Table.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaWBootstrap_Table.Controllers
{
    public class HomeController : Controller
    {
        Empleado empleado = new Empleado();

        public ActionResult Index()
        {
            return View(empleado.cargarLista());
        }

    }
}

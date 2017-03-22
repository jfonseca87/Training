using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogErrors.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int error = 0)
        {
            switch (error)
            {
                case 505:
                    ViewBag.Title = "Ocurrio un error inesperado";
                    ViewBag.Descripcion = "Esto es muy vergonzoso, esperemos que no vuelva a suceder";
                    break;
                
                case 404:
                    ViewBag.Title = "Página no encontrada";
                    ViewBag.Descripcion = "La URL a la que esta intentando acceder no existe";
                    break;

                default:
                    ViewBag.Title = "Página no encontrada";
                    ViewBag.Descripcion = "Algo salió muy mal :(_ _ _";
                    break;
            }

            return View();
        }
    }
}
using CorreosPruebas.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorreosPruebas.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ObtenerCorreos()
        {
            Mails mail = new Mails();

            return View(mail.DescargarCorreos("pop.gmail.com", 995, true, "postmaster.siginec@gmail.com", "Siginec.123"));
        }

    }
}

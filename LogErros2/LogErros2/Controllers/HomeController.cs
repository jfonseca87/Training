using LogErros2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogErros2.Controllers
{
    public class HomeController : Controller
    {
        Book b = new Book();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBook(Book book)
        {
            b.CreateBook(book);
            return RedirectToAction("Index");
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult LogicError()
        {
            return View();
        }
    }
}
using PartialAndRenderPartial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialAndRenderPartial.Controllers
{
    public class HomeController : Controller
    {
        CRBook crBook = new CRBook();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Listado = crBook.listBooks();
            return View();
        }

        [HttpPost]
        public ActionResult NewBook(Book book)
        {
            crBook.createBook(book);
            return RedirectToAction("Index");
        }
    }
}
using LogErrors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogErrors.Controllers
{
    public class HomeController : Controller
    {
        Book book = new Book();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewBook(Book book)
        {
            book.CreateBook(book);
            return RedirectToAction("Index");
        }
    }
}
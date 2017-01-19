using Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Challenge.Controllers
{
    public class BookController : Controller
    {
        Book book = new Book();

        // GET: Book
        public ActionResult Index()
        {
            ViewBag.list = book.listBooks();
            return View();
        }

        [HttpPost]
        public ActionResult Index(List<Book> lstBook)
        {
            return View();
        }
    }
}
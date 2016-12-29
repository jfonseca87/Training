using ConsumerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumerService.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewBook()
        {
            return View();
        }

        public ActionResult EditBook(int bookid, string title, string isbn)
        {
            Book book = new Book() { 
                BookId = bookid,
                Title = title,
                ISBN = isbn
            };

            return View(book);
        }

    }
}
using DemoWepAPI_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace ConsumerDemoWebAPI.Controllers
{
    
    public class JsonBookController : Controller
    {
        // GET: JsonBook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewBook()
        {
            return View();
        }

        public ActionResult EditBook(Book book)
        {
            return View(book);
        }
    }
}
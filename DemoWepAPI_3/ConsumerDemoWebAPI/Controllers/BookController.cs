using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using DemoWepAPI_3.Models;


namespace ConsumerDemoWebAPI.Controllers
{
    public class BookController : Controller
    {
        string Base_URL = "http://localhost:52021/api/book";

        // GET: Book
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(Base_URL);
            var books = JsonConvert.DeserializeObject<List<Book>>(json);

            return View(books);
        }

        public ActionResult NewBook()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> NewBook(Book book)
        {
            var httpClient = new HttpClient();
            var JsonBook = JsonConvert.SerializeObject(book);
            var contentPost = new StringContent(JsonBook, System.Text.Encoding.UTF8, "application/json");
            var json = await httpClient.PostAsync(Base_URL, contentPost);

            if (json.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public async Task<ActionResult> EditBook(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync(Base_URL + "/" + id);
            var book = JsonConvert.DeserializeObject<Book>(json);

            return View(book);
        }

        [HttpPost]
        public async Task<ActionResult> EditBook(Book book)
        {
            var client = new HttpClient();
            var jsonBook = JsonConvert.SerializeObject(book);
            var contentPost = new StringContent(jsonBook, System.Text.Encoding.UTF8, "application/json");
            var json = await client.PutAsync(Base_URL, contentPost);

            if (json.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public async Task<ActionResult> DeleteBook(int id)
        {
            var client = new HttpClient();
            var json = await client.DeleteAsync(Base_URL + "/" + id);

            return RedirectToAction("Index");
        }
    }
}
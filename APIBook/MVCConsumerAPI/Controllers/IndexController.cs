using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ETBook;

namespace MVCConsumerAPI.Controllers
{
    public class IndexController : Controller
    {
        string url = "http://localhost:60466/api/book";
        HttpClient client = new HttpClient();

        // GET: Index
        public async Task<ActionResult> Index()
        {
            var json = await client.GetStringAsync(url);
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
            var json = JsonConvert.SerializeObject(book);
            var contentPost = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var proccess = await client.PostAsync(url, contentPost);

            if (proccess.IsSuccessStatusCode)
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
            var json = await client.GetStringAsync(url + "/" + id);
            var book = JsonConvert.DeserializeObject<Book>(json);

            return View(book);
        }

        [HttpPost]
        public async Task<ActionResult> EditBook(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
            var contentPut = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var PUTProcess = await client.PutAsync(url, contentPut);

            if (PUTProcess.IsSuccessStatusCode)
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
            var process = await client.DeleteAsync(url + "/" + id);

            return RedirectToAction("Index");
        }
    }
}
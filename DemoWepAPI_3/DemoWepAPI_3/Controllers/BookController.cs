using DemoWepAPI_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoWepAPI_3.Controllers
{
    [EnableCors("*", "*", "*")]
    public class BookController : ApiController
    {
        
        private CRUDBook objBook = new CRUDBook();

        // api/book
        public List<Book> GetBook()
        {
            return objBook.listBooks();
        }

        public IHttpActionResult GetBook(int id)
        {
            var book = objBook.getBook(id);

            if (book == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(book);
            }
        }

        public IHttpActionResult PostBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(objBook.newBook(book));
            }
        }

        public IHttpActionResult PutBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(objBook.editBook(book));
            }
        }

        public IHttpActionResult DeleteBook(int id)
        {
            return Ok(objBook.deleteBook(id));
        }
    }
}

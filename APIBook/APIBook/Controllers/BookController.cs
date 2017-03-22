using DALBook;
using ETBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBook.Controllers
{
    public class BookController : ApiController
    {
        private CRUDBook objBook = new CRUDBook();

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
                objBook.InsertBook(book);
                return Ok();
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
                objBook.EditBook(book);
                return Ok();
            }
        }

        public IHttpActionResult DeleteBook(int id)
        {
            objBook.DeleteBook(id);
            return Ok();
        }
    }
}

using BookService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUDService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRUDService.svc or CRUDService.svc.cs at the Solution Explorer and start debugging.
    public class CRUDService : ICRUDService
    {
        BookCRUD objBook = new BookCRUD();
        
        public List<Book> listBook()
        {
            return objBook.listBooks();
        }

        public Book getBook(string id)
        {
            return objBook.getBook(id);
        }

        public bool newBook(Book book)
        {
            return objBook.newBook(book);
        }

        public bool editBook(Book book)
        {
            return objBook.editBook(book);
        }

        public bool deleteBook(string id)
        {
            return objBook.deleteBook(id);
        }
    }
}

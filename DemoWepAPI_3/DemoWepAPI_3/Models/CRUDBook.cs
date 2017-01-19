using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWepAPI_3.Models
{
    public class CRUDBook
    {
        private BookContext bookContext = new BookContext();

        public List<Book> listBooks()
        {
            try
            {
                return bookContext.Book.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Book getBook(int id)
        {
            try
            {
                return bookContext.Book.Where(b => b.BookId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool newBook(Book book)
        {
            try
            {
                bookContext.Entry(book).State = System.Data.Entity.EntityState.Added;
                bookContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                var mensaje = new Exception(ex.Message);
                return false;
            }
        }

        public bool editBook(Book book)
        {
            try
            {
                bookContext.Entry(book).State = System.Data.Entity.EntityState.Modified;
                bookContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                var mensaje = new Exception(ex.Message);
                return false;
            }
        }

        public bool deleteBook(int id)
        {
            try
            {
                Book book = bookContext.Book.Where(b => b.BookId == id).FirstOrDefault();
                bookContext.Entry(book).State = System.Data.Entity.EntityState.Deleted;
                bookContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                var mensaje = new Exception(ex.Message);
                return false;
            }
        }
    }
}
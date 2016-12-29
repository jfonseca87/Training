using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Model
{
    public class BookCRUD
    {
        public List<Book> listBooks()
        {
            try
            {
                using (var context = new BookContext())
                {
                    return context.Book.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Book getBook(string id)
        {
            try
            {
                int bookId = Convert.ToInt16(id);

                using (var context = new BookContext())
                {
                    return context.Book.Where(b => b.BookId == bookId).First();
                }
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
                using (var context = new BookContext())
                {
                    context.Entry(book).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
                return false;
            }
        }

        public bool editBook(Book book)
        {
            try
            {
                using (var context = new BookContext())
                {
                    context.Entry(book).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
                return false;
            }
        }

        public bool deleteBook(string id)
        {
            try
            {
                int idBook = Convert.ToInt16(id); 

                using (var context = new BookContext())
                {
                    Book book = context.Book.Where(b => b.BookId == idBook).First();
                    context.Entry(book).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
                return false;
            }
        }
    }
}
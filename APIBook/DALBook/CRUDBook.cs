using ETBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALBook
{
    public class CRUDBook
    {
        private BookContext context = new BookContext();

        public List<Book> listBooks()
        {
            try
            {
                return context.Book.ToList();
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
                return context.Book.Where(b => b.BookId == id).First();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertBook(Book book)
        {
            try 
	        {
                context.Entry(book).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
	        }
	        catch (Exception ex)
	        {
		        throw new Exception(ex.Message);
	        }
        }

        public void EditBook(Book book)
        {
            try
            {
                context.Entry(book).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteBook(int id)
        {
            try
            {
                var DelBook = context.Book.Where(b => b.BookId == id).First();

                context.Entry(DelBook).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

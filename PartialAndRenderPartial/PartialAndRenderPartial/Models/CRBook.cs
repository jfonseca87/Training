using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialAndRenderPartial.Models
{
    public class CRBook
    {
        BookContext context = new BookContext();

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

        public void createBook(Book book)
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

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
    }
}
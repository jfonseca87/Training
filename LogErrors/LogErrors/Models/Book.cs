namespace LogErrors.Models
{
    using LogErrors.Error_Log;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(10)]
        public string ISBN { get; set; }

        public void CreateBook(Book book)
        {
            ErrorLog Elog = new ErrorLog();

            try 
	        {	        
		        using(var context = new BookContext())
                {
                    context.Entry(book).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                }
	        }
	        catch (Exception ex)
	        {
                Elog.SaveError(this, ex);
                throw;
	        }
        }
    }
}

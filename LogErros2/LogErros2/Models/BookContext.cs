using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LogErros2.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("name=BookContext")
        { }

        public DbSet<Book> Book { get; set; }
    }
}
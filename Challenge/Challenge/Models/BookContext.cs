using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Challenge.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("name=BookContext")
        { }

        public DbSet<Book> Book { get; set; }
    }
}
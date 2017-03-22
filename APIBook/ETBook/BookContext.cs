using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ETBook
{
    public class BookContext : DbContext
    {
        public BookContext() 
            : base("name=BookContext") 
        {}

        public DbSet<Book> Book { get; set; }
    }
}

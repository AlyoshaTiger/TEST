using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTest
{
    class BookContext : DbContext
    {

        public BookContext() : base("DBConnection")
        { }

        public DbSet<Books> books { get; set; }
        public DbSet<Buyers> Buyers { get; set; }
    }
}

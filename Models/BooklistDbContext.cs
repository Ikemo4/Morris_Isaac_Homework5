using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morris_Isaac_Homework5.Models
{
    //Create Booklist context class
    public class BooklistDbContext : DbContext
    {
        public BooklistDbContext (DbContextOptions<BooklistDbContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}

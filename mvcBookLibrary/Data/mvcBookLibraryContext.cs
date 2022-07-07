using Microsoft.EntityFrameworkCore;
using mvcBookLibrary.Models;

namespace mvcBookLibrary.Data
{
    public class mvcBookLibraryContext : DbContext
    {
        public mvcBookLibraryContext(DbContextOptions<mvcBookLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book>? Book { get; set; }
    }
}

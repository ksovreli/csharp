using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public BookStoreContext(DbContextOptions options) : base(options)
        {
        }

        protected BookStoreContext()
        {
        }
    }
}

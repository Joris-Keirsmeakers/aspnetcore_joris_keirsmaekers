using Microsoft.EntityFrameworkCore;

namespace Bibliotheek.Entities
{
    public class EntityContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

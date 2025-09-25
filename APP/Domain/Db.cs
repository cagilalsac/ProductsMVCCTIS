using Microsoft.EntityFrameworkCore;

namespace APP.Domain
{
    public class Db : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public Db(DbContextOptions options) : base(options)
        {
        }
    }
}

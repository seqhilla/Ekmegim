using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        DBBilgileri db = new DBBilgileri();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(db.ConnectingString);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}


using Microsoft.EntityFrameworkCore;
using SQLiteDemoWebApi.Entities;

namespace SQLiteDemoWebApi.Contexts
{
    public class AthleteSQLiteDbContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }

        public AthleteSQLiteDbContext(DbContextOptions<AthleteSQLiteDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            base.OnModelCreating(modelBuider);
        }
    }
}

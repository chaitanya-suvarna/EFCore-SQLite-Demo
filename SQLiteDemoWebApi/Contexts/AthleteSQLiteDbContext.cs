using Microsoft.EntityFrameworkCore;
using SQLiteDemoWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

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

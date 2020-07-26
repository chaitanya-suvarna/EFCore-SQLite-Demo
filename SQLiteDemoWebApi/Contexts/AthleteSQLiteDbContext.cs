using Microsoft.EntityFrameworkCore;
using SQLiteDemoWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLiteDemoWebApi.Contexts
{
    public class AthleteSQLiteDbContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            base.OnModelCreating(modelBuider);
        }
    }
}

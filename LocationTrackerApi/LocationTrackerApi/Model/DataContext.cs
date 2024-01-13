using Microsoft.EntityFrameworkCore;
using System;

namespace LocationTrackerApi.Model
{
    
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

         public DbSet<User> User { get; set; }
         public DbSet<Location> Location { get; set; }
    }
    
}

using Microsoft.EntityFrameworkCore;
using NZwalks.API.Models.Domain;


namespace NZwalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            // Constructor to pass options to the base DbContext class
        }

        // DbSet properties representing database tables
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}

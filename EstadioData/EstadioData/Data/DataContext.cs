using EstadioData.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstadioData.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasIndex(c => c.Name).IsUnique();
        }
    }
}

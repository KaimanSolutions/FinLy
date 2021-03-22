using finly.Models;
using Microsoft.EntityFrameworkCore;

namespace finly.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Profile>()
                .HasMany(p => p.Clients)
                .WithOne(p => p.Profile!)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder
                .Entity<Client>()
                    .HasOne(c => c.Profile)
                    .WithMany(c => c.Clients)
                    .HasForeignKey(c => c.ProfileId);
        }
    }
}
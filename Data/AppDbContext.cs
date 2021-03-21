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
    }
}
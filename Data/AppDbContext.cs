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

        public DbSet<ClientPreviousName> ClientPreviousNames { get; set; }

        public DbSet<ClientMarketingConsent> ClientMarketingConsents { get; set; }

        public DbSet<CompanyClient> CompanyClients { get; set; }

        public DbSet<CompanyClientSICCode> CompanyClientSICCodes { get; set; }

        public DbSet<Mortgage> Mortgages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Profile relationships    
            modelBuilder
                .Entity<Profile>()
                .HasMany(p => p.Clients)
                .WithOne(p => p.Profile!)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder
                .Entity<Profile>()
                .HasMany(p => p.CompanyClients)
                .WithOne(p => p.Profile!)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder
                .Entity<Profile>()
                .HasMany(p => p.Mortgages)
                .WithOne(p => p.Profile!)
                .HasForeignKey(p => p.ProfileId);

            // Client relationships
            modelBuilder
                .Entity<Client>()
                .HasOne(c => c.Profile!)
                .WithMany(c => c.Clients)
                .HasForeignKey(c => c.ProfileId);
            modelBuilder
                .Entity<Client>()
                .HasMany(c => c.ClientMarketingConsents)
                .WithOne(c => c.Client!)
                .HasForeignKey(c => c.ClientId);

            modelBuilder
                .Entity<Client>()
                .HasMany(c => c.PreviousNames)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId);
            
            // ClientMarketingConsent relationships
            modelBuilder
                .Entity<ClientMarketingConsent>()
                .HasOne(c => c.Client!)
                .WithMany(c => c.ClientMarketingConsents)
                .HasForeignKey(c => c.ClientId);

            // CompanyClient relationships
            modelBuilder
                .Entity<CompanyClient>()
                .HasOne(c => c.Profile!)
                .WithMany(c => c.CompanyClients)
                .HasForeignKey(c => c.ProfileId);

            modelBuilder
                .Entity<CompanyClient>()
                .HasMany(c => c.CompanyClientSICCodes)
                .WithOne(c => c.CompanyClient)
                .HasForeignKey(c => c.CompanyClientId);

            modelBuilder
                .Entity<CompanyClient>()
                .HasMany(c => c.Mortgages)
                .WithOne(c => c.CompanyClient)
                .HasForeignKey(c => c.CompanyClientId);

            // CompanyClientSICCode Relationships
            modelBuilder
                .Entity<CompanyClientSICCode>()
                .HasOne(c => c.CompanyClient!)
                .WithMany(c => c.CompanyClientSICCodes)
                .HasForeignKey(c => c.CompanyClientId);

            // Mortgage relationships
            modelBuilder
                .Entity<Mortgage>()
                .HasOne(m => m.Profile!)
                .WithMany(m => m.Mortgages)
                .HasForeignKey(m => m.ProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Mortgage>()
                .HasMany(m => m.MortgageClients)
                .WithOne(m => m.Mortgage!)
                .HasForeignKey(m => m.MortgageId);
            
            modelBuilder
                .Entity<Mortgage>()
                .HasOne(m => m.CompanyClient)
                .WithMany(m => m.Mortgages)
                .HasForeignKey(m => m.CompanyClientId);

            // MortgageClient relationships
            modelBuilder
                .Entity<MortgageClient>()
                .HasKey(mc => new {mc.MortgageId, mc.ClientId});

            modelBuilder
                .Entity<MortgageClient>()
                .HasOne(mc => mc.Client)
                .WithMany(mc => mc.MortgageClients)
                .HasForeignKey(mc => mc.ClientId);

            modelBuilder
                .Entity<MortgageClient>()
                .HasOne(mc => mc.Mortgage)
                .WithMany(mc => mc.MortgageClients)
                .HasForeignKey(mc => mc.MortgageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
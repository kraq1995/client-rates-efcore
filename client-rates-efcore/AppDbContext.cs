using client_rates_efcore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace client_rates_efcore
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Client>().ToTable("Clients");
            builder.Entity<Client>().HasKey(p => p.Id);
            builder.Entity<Client>().Property(p => p.Name).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Client>().Property(p => p.Name).IsRequired();
            builder.Entity<Client>().Property(p => p.Surname);
            builder.Entity<Client>().Property(p => p.PeselNr);
            builder.Entity<Client>().Property(p => p.IdDocNumber);
            builder.Entity<Client>()
                .HasMany(p => p.Rates)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.ClientId);

            builder.Entity<Rate>().ToTable("Rates");
            builder.Entity<Rate>().HasKey(p => p.Id);
            builder.Entity<Rate>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Rate>().Property(p => p.Stars).IsRequired();
            builder.Entity<Rate>().Property(p => p.Opinion).IsRequired();
        }
    }
}

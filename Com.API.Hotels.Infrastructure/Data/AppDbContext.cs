using Com.API.Hotels.Core.Aggregates;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.API.Hotels.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /**
         * Declaring the db sets
         */
        public DbSet<Country> Countries { get; set; }
        public DbSet<StateProvince> StateProvinces{ get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<AddressLine> AddressLines{ get; set; }
        public DbSet<CustomAttribute> CustomAttributes{ get; set; }
        public DbSet<Facility> Facilities{ get; set; }
        public DbSet<Hotel> Hotels{ get; set; }
        public DbSet<HotelRate> HotelRates { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserHotelReviews> HotelReviews { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // configures relationships
            modelBuilder.Entity<StateProvince>()
                        .HasOne<Country>(s => s.Country)
                        .WithMany(g => g.StateProvinces)
                        .HasForeignKey(cs => cs.CountryId);

            modelBuilder.Entity<AddressLine>()
                        .HasOne<Address>(s => s.Address)
                        .WithMany(g => g.AddressLines)
                        .HasForeignKey(cs => cs.AddressId);

            modelBuilder.Entity<CustomAttribute>()
                        .HasOne<Address>(s => s.Address)
                        .WithMany(g => g.CustomAttributes)
                        .HasForeignKey(cs => cs.AddressId);
        }

        
    }
}

using Microsoft.EntityFrameworkCore;
using RestaurantMVCNET.Models;

namespace RestaurantMVCNET.Data
{
    public class MvcRestaurantContext : DbContext
    {
        public MvcRestaurantContext(DbContextOptions<MvcRestaurantContext> options)
            : base(options)
        {

        }

        public DbSet<Restaurant>? Restaurants { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Table>? Tables { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().ToTable("Restaurant");
            modelBuilder.Entity<Table>().ToTable("Table");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");

            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reservation>().HasKey(c => new {c.RestaurantId, c.CustomerId, c.TableId});
        }

    }
}

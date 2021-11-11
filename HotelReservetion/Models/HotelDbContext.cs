using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelReservetion.Models
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Billing> Billing { get; set; }

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<Ratings>().ToTable("Ratings");
            modelBuilder.Entity<Billing>().ToTable("Billing");
        }


    }
}

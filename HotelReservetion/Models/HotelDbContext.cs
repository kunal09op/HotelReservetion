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

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Employee>().ToTable("Employees");
        }


    }
}

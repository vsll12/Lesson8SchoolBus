using Lesson8SchoolBus.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8SchoolBus.Data
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7F74UDB;Initial Catalog=SchoolBusDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Parent>Parents { get; set; }
        public DbSet<Ride>Rides { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using RealLabBook.Models;

namespace RealLabBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Tool>().ToTable("Tool");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Blacklist>().ToTable("Blacklist");

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    id = Guid.NewGuid(),
                    name = "admin",
                    surname = "RealLabbook",
                    email = "admin@kmitl.ac.th",
                    password = BCrypt.Net.BCrypt.HashPassword("Admin123"),
                    role = "อาจารย์",
                    status = "Normal"
                },
                new User
                {
                    id = Guid.NewGuid(),
                    name = "วรุต",
                    surname = "เพชรสุวรรณ",
                    email = "6101010949@kmitl.ac.th",
                    password = BCrypt.Net.BCrypt.HashPassword("Varut123"),
                    role = "นักศึกษา",
                    status = "Normal"
                }
            );

        }
    }
}

﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RealLabBook.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RealLabBook.Data;


namespace RealLabBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<RealLabBookUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tool>().ToTable("Tool");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Blacklist>().ToTable("Blacklist");
        }
    }
}

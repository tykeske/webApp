/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      Setting up context for database session to use with Entity Framework
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Models;
using AccountManagement.ViewModels;


namespace AccountManagement.Data
{
    public class accountContext : DbContext
    {
        public accountContext (DbContextOptions<accountContext> options)
            : base(options)
        {
        }

        public DbSet<userAccount> userAccount { get; set; }
        public DbSet<pantryLocation> pantryLocation { get; set; }
        public DbSet<userLocation> userLocation { get; set; }
        public DbSet<userRole> userRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<userAccount>().ToTable("user_account");
            modelBuilder.Entity<pantryLocation>().ToTable("pantry_location");
            modelBuilder.Entity<userLocation>().ToTable("user_location");
            modelBuilder.Entity<userRole>().ToTable("user_role");

            // Set composite key using Fluent API
            modelBuilder.Entity<userLocation>()
                .HasKey(c => new { c.userId, c.locationId });
        }

        public DbSet<AccountManagement.ViewModels.userSubscription> userSubscription { get; set; }
    }
}

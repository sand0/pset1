using System;
using System.Collections.Generic;
using System.Text;
using Frendzone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Frendzone.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                         new IdentityRole { Name = "User", NormalizedName = "User".ToUpper() });

            //
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Owner)
                .WithMany(u => u.UsersEvents);
            
            // Event-User many-to-many
            //modelBuilder.Entity<EventUser>()
            //    .HasKey(t => new { t.UserId, t.EventId });
            //modelBuilder.Entity<EventUser>()
            //    .HasOne(eu => eu.User)
            //    .WithMany(u => u.EventUser)
            //    .HasForeignKey(eu => eu.UserId);
            //modelBuilder.Entity<EventUser>()
            //    .HasOne(eu => eu.Event)
            //    .WithMany(e => e.EventUser)
            //    .HasForeignKey(eu => eu.EventId);

            // User-Category many-to-many
            modelBuilder.Entity<UserCategory>()
                .HasKey(t => new { t.UserId, t.CategoryId });
            modelBuilder.Entity<UserCategory>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCategory)
                .HasForeignKey(uc => uc.UserId);
            modelBuilder.Entity<UserCategory>()
                .HasOne(uc => uc.Category)
                .WithMany(c => c.UserCategory)
                .HasForeignKey(uc => uc.CategoryId);

            // Event-Category many-to-many
            modelBuilder.Entity<EventCategory>()
                .HasKey(t => new { t.EventId, t.CategoryId });
            modelBuilder.Entity<EventCategory>()
                .HasOne(ec => ec.Event)
                .WithMany(e => e.EventCategory)
                .HasForeignKey(ec => ec.EventId);
            modelBuilder.Entity<EventCategory>()
                .HasOne(ec => ec.Category)
                .WithMany(c => c.EventCategory)
                .HasForeignKey(uc => uc.CategoryId);
        }
    }
}

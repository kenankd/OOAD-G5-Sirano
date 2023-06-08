using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sirano.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sirano.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RegisteredUser> RegisteredUser { get; set; }
        public DbSet<Clothing> Clothing { get; set; }
        public DbSet<Footwear> Footwear { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Cart> Cart { get; set; }
        //public IEnumerable Cart { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser");
            modelBuilder.Entity<Clothing>().ToTable("Clothing");
            modelBuilder.Entity<Footwear>().ToTable("Footwear");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Store>().ToTable("Store");
            modelBuilder.Entity<Cart>().ToTable("Cart").HasMany(c => c.Product).WithOne(p => p.Cart);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Sirano.Models.Cart> Cart_1 { get; set; }
    }
}

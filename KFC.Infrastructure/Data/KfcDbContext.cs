using KFC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Infrastructure.Data
{
    public class KfcDbContext : DbContext
    { 
        public DbSet<Product> Products { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public KfcDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using BaseMarket.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.EF
{
    class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<AttributesPrices> AttributesPrices { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<TransactStatus> TransactStatuses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Pages> Pages { get; set; }
    }
}

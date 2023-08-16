using BaseMarket.Data.Configurations;
using BaseMarket.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.EF
{
    public class MarketDbContext : IdentityDbContext<AppAccount, AppRole, Guid>
    {
        public MarketDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {;
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new AppAccountConfiguration());

            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.ApplyConfiguration(new AttributesConfiguration());

            modelBuilder.ApplyConfiguration(new AttributesPricesConfiguration());

            modelBuilder.ApplyConfiguration(new CommentConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.ApplyConfiguration(new LocationConfiguration());

            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

            modelBuilder.ApplyConfiguration(new PagesConfiguration());

            modelBuilder.ApplyConfiguration(new RatingConfiguration());

            modelBuilder.ApplyConfiguration(new PostsConfiguration());

            modelBuilder.ApplyConfiguration(new ShipperConfiguration());

            modelBuilder.ApplyConfiguration(new StatisticConfiguration());

            modelBuilder.ApplyConfiguration(new TransactStatusConfiguration());

            /*  base.OnModelCreating(modelBuilder);*/
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

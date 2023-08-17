using BaseMarket.Data.Entities;
using BaseMarket.Data.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of MarketOnline" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword page of MarketOnline" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description page of MarketOnline" }
               );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Hoa quả",
                    Description = "Hoa quả mới nhập về rất ngon",
                    ParentID = null,
                    Levels = 2,
                    DisplayOrder = 2,
                    Active = Active.Active,
                    Image = "",
                    Title = "",
                    Alias = "hoa-qua",
                    MetaTitle = "Hoa quả rất ngọt và ngon",
                    MetaDes = "Hoa quả rất ngọt và ngon",
                    MetaKey = "",
                    SchemaMarkup = "",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Cover = ""
                },
                 new Category()
                 {
                     CategoryID = 1,
                     CategoryName = "Thịt ",
                     Description = "Thịt mới nhập về rất ngon",
                     ParentID = null,
                     Levels = 1,
                     DisplayOrder = 1,
                     Active = Active.Active,
                     Image = "",
                     Title = "",
                     Alias = "thit",
                     MetaTitle = "Thịt rất ngon và tốt cho sức khỏe ",
                     MetaDes = "Thịt rất ngon và tốt cho sức khỏe ",
                     MetaKey = "",
                     SchemaMarkup = "",
                     CreateDate = DateTime.Now,
                     UpdateDate = DateTime.Now,
                     Cover = ""
                 }
                ) ;
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   ProductID = 1,
                   ProductName = "Trái táo",
                   Description = "Trái táo giòn tan",
                   ShortDesc = "Trái táo giòn tan",
                   Price = 15000, 
                   Discount = 5000, 
                   Active = Active.Active,
                   BestSellers = BestSellers.Yes,
                   HomeFlag = HomeFlag.Press,
                   Image = "",
                   Video = "",
                   Tags = "",
                   Title = "",
                   Alias = "hoa-qua",
                   MetaTitle = "Hoa quả rất ngọt và ngon",
                   MetaDes = "Hoa quả rất ngọt và ngon",
                   MetaKey = "",
                   CreateDate = DateTime.Now,
                   UpdateDate = DateTime.Now,
                   UnitStock = 50,
               },
               new Product()
               {
                   ProductID = 2,
                   ProductName = "Trái xoài",
                   Description = "Trái xoài giòn tan",
                   ShortDesc = "Trái xoài giòn tan",
                   Price = 30000, 
                   Discount = 5000, 
                   Active = Active.Active,
                   BestSellers = BestSellers.Yes,
                   HomeFlag = HomeFlag.Press,
                   Image = "",
                   Video = "",
                   Tags = "",
                   Title = "",
                   Alias = "hoa-qua",
                   MetaTitle = "Hoa quả rất ngọt và ngon",
                   MetaDes = "Hoa quả rất ngọt và ngon",
                   MetaKey = "",
                   CreateDate = DateTime.Now,
                   UpdateDate = DateTime.Now,
                   UnitStock = 20,
               }         
               ) ;
        }
    }
}

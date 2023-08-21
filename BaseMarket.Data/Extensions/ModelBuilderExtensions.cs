using BaseMarket.Data.Entities;
using BaseMarket.Data.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
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
                    ParentID = 0,
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
                     CategoryID = 2,
                     CategoryName = "Thịt ",
                     Description = "Thịt mới nhập về rất ngon",
                     ParentID = 0,
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
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("C1B3EFBD-1E1F-47B5-B5D6-9062046F0166");
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                Name = "admin",
                NormalizedName = "admin",
                ShortDesc = "Administrator role",
                CreateDate = new DateTime(2023, 08, 18),
                UpdateDate = new DateTime(2023, 08, 18),
            });


            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid("C1B3EFBD-1E1F-47B5-B5D6-9062046F0166"),
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "ThanhHaiPC2002@gmail.com",
                NormalizedEmail = "ThanhHaiPC2002@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                Fullname = "Phạm Thanh Hải",
                Avatar = "",
                Phone = "0967021502",
                Address = "Biên Hòa Đồng Nai",
                CreateDate = new DateTime(2023, 08, 18),
                UpdateDate = new DateTime(2023, 08, 18),
                LastLogin = new DateTime(2023, 08, 18),
               

            }); ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}

using BaseMarket.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Configurations
{
    class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");
            // Giới hạn độ dài Fullname
            builder.Property(x => x.Fullname).HasMaxLength(100);        
            // Giới hạn độ dài Address
            builder.Property(x=>x.Address).HasMaxLength(250);
            // Bắt buộc phải có CreateDate
            builder.Property(e => e.CreateDate).IsRequired(); 
            // Bắt buộc phải có UpdateDate
            builder.Property(e => e.UpdateDate).IsRequired();
            // Bắt buộc phải có LastLogin
            builder.Property(e => e.LastLogin).IsRequired();
            // Avatar, bắt buộc
            builder.Property(e => e.Avatar).IsRequired(); 
            // Số điện thoại, bắt buộc
            builder.Property(e => e.Phone).IsRequired();
           

          
        }
    }
}

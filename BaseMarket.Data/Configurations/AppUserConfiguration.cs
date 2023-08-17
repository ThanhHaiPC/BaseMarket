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
            // Bắt buộc phải có Token
            builder.Property(x => x.Token).IsRequired();
            // Bắt buộc phải có trạng thái Active
            builder.Property(x=> x.Active).IsRequired();
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
            // Email, bắt buộc
            builder.Property(e => e.Email).IsRequired();
            // Số điện thoại, bắt buộc
            builder.Property(e => e.Phone).IsRequired();
            // Quận/huyện, bắt buộc
            builder.Property(e => e.Distric).IsRequired();
            // Phường/xã, bắt buộc
            builder.Property(e => e.Ward).IsRequired();
            // Thành phố, bắt buộc
            builder.Property(e => e.City).IsRequired();
            // Mật khẩu, bắt buộc
            builder.Property(e => e.Password).IsRequired();

          
        }
    }
}

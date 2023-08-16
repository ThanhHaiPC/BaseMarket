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
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.CustomerID); // Khóa chính

            builder.Property(e => e.FullName).IsRequired().HasMaxLength(100); // Tên đầy đủ, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Birthday).IsRequired(); // Ngày sinh, bắt buộc

            builder.Property(e => e.Avatar).HasMaxLength(100); // Avatar, giới hạn độ dài

            builder.Property(e => e.Address).HasMaxLength(200); // Địa chỉ, giới hạn độ dài

            builder.Property(e => e.Email).IsRequired().HasMaxLength(100); // Email, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Phone).HasMaxLength(20); // Số điện thoại, giới hạn độ dài

            builder.Property(e => e.Distric).HasMaxLength(100); // Quận/Huyện, giới hạn độ dài

            builder.Property(e => e.Ward).HasMaxLength(100); // Phường/Xã, giới hạn độ dài

            builder.Property(e => e.City).HasMaxLength(100); // Thành phố, giới hạn độ dài

            builder.Property(e => e.Password).IsRequired(); // Mật khẩu, bắt buộc

            builder.Property(e => e.Token).IsRequired(); // Token, bắt buộc

            builder.Property(e => e.Active).IsRequired(); // Trạng thái Active, bắt buộc


            builder.Property(e => e.CreateDate).IsRequired(); // Ngày tạo, bắt buộc

            builder.Property(e => e.UpdateDate).IsRequired(); // Ngày cập nhật, bắt buộc

            builder.Property(e => e.LastLogin).IsRequired(); // Lần đăng nhập cuối, bắt buộc

            builder.HasOne(e => e.Location)
              .WithMany()
              .HasForeignKey(e => e.LocationID)
              .OnDelete(DeleteBehavior.Restrict); // Liên kết với Location, không xóa liên quan
        }
    }
}

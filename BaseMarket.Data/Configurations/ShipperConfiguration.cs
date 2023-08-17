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
    internal class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("Shippers"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.ShipperID); // Khóa chính

            builder.Property(e => e.ShipperName).IsRequired().HasMaxLength(100); // Tên người giao hàng, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Phone).HasMaxLength(20); // Số điện thoại, giới hạn độ dài

            builder.Property(e => e.ContactPerson).HasMaxLength(100); // Người liên hệ, giới hạn độ dài

            builder.Property(e => e.Company).HasMaxLength(100); // Công ty, giới hạn độ dài

            builder.Property(e => e.Email).HasMaxLength(100); // Email, giới hạn độ dài

            builder.Property(e => e.ShipDate).IsRequired(); // Ngày giao hàng, bắt buộc
        }
    }
}

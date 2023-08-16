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
    internal class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.LocationID); // Khóa chính

            builder.Property(e => e.Name).IsRequired().HasMaxLength(100); // Tên, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Type).HasMaxLength(50); // Loại, giới hạn độ dài

            builder.Property(e => e.NameWithType).HasMaxLength(200); // Tên kèm loại, giới hạn độ dài

            builder.Property(e => e.PathWithType).HasMaxLength(500); // Đường dẫn kèm loại, giới hạn độ dài

            builder.Property(e => e.ParentCode).IsRequired(); // Mã cha, bắt buộc

            builder.Property(e => e.Levels).IsRequired(); // Số cấp, bắt buộc

            builder.Property(e => e.City).HasMaxLength(100); // Thành phố, giới hạn độ dài

            builder.Property(e => e.Country).HasMaxLength(100); // Quốc gia, giới hạn độ dài

            builder.Property(e => e.Province).HasMaxLength(100); // Tỉnh, giới hạn độ dài

            builder.Property(e => e.Slug).HasMaxLength(100); // Slug, giới hạn độ dài
        }
    }
}

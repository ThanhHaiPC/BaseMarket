using BaseMarket.Data.Entities;
using BaseMarket.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Configurations
{
    internal class PagesConfiguration : IEntityTypeConfiguration<Pages>
    {
        public void Configure(EntityTypeBuilder<Pages> builder)
        {
            builder.ToTable("Pages"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.PageID); // Khóa chính

            builder.Property(e => e.PageName).IsRequired().HasMaxLength(100); // Tên trang, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Contents).IsRequired(); // Nội dung trang, bắt buộc

            builder.Property(e => e.Image).HasMaxLength(100); // Ảnh, giới hạn độ dài

            builder.Property(e => e.Title).HasMaxLength(100); // Tiêu đề, giới hạn độ dài

            builder.Property(e => e.MetaTitle).HasMaxLength(100); // Tiêu đề Meta, giới hạn độ dài

            builder.Property(e => e.MetaDes).HasMaxLength(200); // Mô tả Meta, giới hạn độ dài

            builder.Property(e => e.MetaKey).HasMaxLength(100); // Từ khóa Meta, giới hạn độ dài

            builder.Property(e => e.Alias).HasMaxLength(100); // Bí danh, giới hạn độ dài

            builder.Property(e => e.DisplayOrder).IsRequired(); // Thứ tự hiển thị, bắt buộc

            builder.Property(e => e.CreateDate).IsRequired(); // Ngày tạo, bắt buộc

            builder.Property(e => e.UpdateDate).IsRequired(); // Ngày cập nhật, bắt buộc

            builder.Property(x => x.Active).HasDefaultValue(Active.Active);
        }
    }
}

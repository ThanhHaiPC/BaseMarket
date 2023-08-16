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
    internal class PostsConfiguration : IEntityTypeConfiguration<Posts>
    {
        public void Configure(EntityTypeBuilder<Posts> builder)
        {
            builder.ToTable("Posts"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.PostID); // Khóa chính

            builder.Property(e => e.Title).IsRequired().HasMaxLength(200); // Tiêu đề, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Contents).IsRequired(); // Nội dung bài viết, bắt buộc

            builder.Property(e => e.Image).HasMaxLength(100); // Ảnh, giới hạn độ dài

            builder.Property(e => e.Alias).HasMaxLength(100); // Bí danh, giới hạn độ dài

            builder.Property(e => e.Author).HasMaxLength(100); // Tác giả, giới hạn độ dài

            builder.Property(e => e.Tags).HasMaxLength(100); // Thẻ tags, giới hạn độ dài

            builder.Property(e => e.MetaTitle).HasMaxLength(100); // Tiêu đề Meta, giới hạn độ dài

            builder.Property(e => e.MetaDes).HasMaxLength(200); // Mô tả Meta, giới hạn độ dài

            builder.Property(e => e.MetaKey).HasMaxLength(100); // Từ khóa Meta, giới hạn độ dài

            // Số lượt xem không cần bắt buộc, có giá trị mặc định
            builder.Property(e => e.Views).HasDefaultValue(0);

            builder.Property(x => x.Active).HasDefaultValue(Active.Active);
        }
    }
}

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
    internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.CommentID); // Khóa chính

            builder.Property(e => e.Contents).IsRequired(); // Nội dung bình luận, bắt buộc

            builder.Property(e => e.CreateDate).IsRequired(); // Ngày tạo, bắt buộc

            // Khóa ngoại liên kết đến Post
            builder.HasOne(e => e.Posts)
                .WithMany()
                .HasForeignKey(e => e.PostID)
                .OnDelete(DeleteBehavior.Cascade); // Liên kết với Post, xóa liên quan khi Post bị xóa

            // Khóa ngoại liên kết đến Customer
            builder.HasOne(e => e.Customer)
                .WithMany()
                .HasForeignKey(e => e.CustomerID)
                .OnDelete(DeleteBehavior.Restrict); // Liên kết với Customer, không xóa liên quan
        });
        }
    }
}

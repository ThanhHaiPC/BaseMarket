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

            builder.HasOne(x => x.Posts).WithMany(x => x.Comment).HasForeignKey(x => x.PostID);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Comments).HasForeignKey(x => x.UserID);

        }
    }
}

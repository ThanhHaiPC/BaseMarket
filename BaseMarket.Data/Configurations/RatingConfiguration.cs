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
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Ratings"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.RatingID); // Khóa chính

            builder.Property(e => e.Stars).IsRequired(); // Số sao, bắt buộc

            builder.Property(e => e.Comment).HasMaxLength(500); // Bình luận, giới hạn độ dài

            builder.Property(e => e.CreateDate).IsRequired(); // Ngày tạo, bắt buộc

          
            builder.HasOne(x => x.AppUser).WithMany(x => x.Ratings).HasForeignKey(x => x.UserID);

            builder.HasOne(x => x.Product).WithMany(x => x.Ratings).HasForeignKey(x => x.ProductID);

        }
    }
}

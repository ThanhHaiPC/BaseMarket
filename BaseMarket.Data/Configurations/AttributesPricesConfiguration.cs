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
    class AttributesPricesConfiguration : IEntityTypeConfiguration<AttributesPrices>
    {
        public void Configure(EntityTypeBuilder<AttributesPrices> builder)
        {
            builder.ToTable("AttributesPrices"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.AttributesPriceID); // Khóa chính

            builder.Property(e => e.AttributeID).IsRequired(); // Khóa ngoại liên kết tới Attributes

            builder.Property(e => e.ProductID).IsRequired(); // Khóa ngoại liên kết tới sản phẩm

            builder.Property(e => e.Price).IsRequired(); // Bắt buộc phải có giá

            builder.Property(x => x.Active).HasDefaultValue(Active.Active); 

            builder.HasOne(e => e.Attributes)
              .WithMany()
              .HasForeignKey(e => e.AttributeID)
              .OnDelete(DeleteBehavior.Restrict); // Liên kết với Attributes, không xóa liên quan
        }
    }
}

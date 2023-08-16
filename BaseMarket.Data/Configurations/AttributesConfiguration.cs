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
    internal class AttributesConfiguration : IEntityTypeConfiguration<Attributes>
    {
        public void Configure(EntityTypeBuilder<Attributes> builder)
        {
            builder.ToTable("Attributes"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.AttributeID); // Khóa chính

            builder.Property(e => e.Name).IsRequired().HasMaxLength(100); // Tên thuộc tính, bắt buộc và giới hạn độ dài
        }
    }
}

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
    internal class TransactStatusConfiguration : IEntityTypeConfiguration<TransactStatus>
    {
        public void Configure(EntityTypeBuilder<TransactStatus> builder)
        {
            builder.ToTable("TransactStatuses"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.TransactStatusID); // Khóa chính

            builder.Property(e => e.Status).IsRequired().HasMaxLength(50); // Trạng thái, bắt buộc và giới hạn độ dài

            builder.Property(e => e.Description).HasMaxLength(200); // Mô tả, giới hạn độ dài
        }
    }
}

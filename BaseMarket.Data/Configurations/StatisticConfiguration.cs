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
    internal class StatisticConfiguration : IEntityTypeConfiguration<Statistic>
    {
        public void Configure(EntityTypeBuilder<Statistic> builder)
        {
            builder.ToTable("Statistics"); // Tên bảng trong cơ sở dữ liệu

            builder.HasKey(e => e.StatisticID); // Khóa chính

            builder.Property(e => e.Date).IsRequired(); // Ngày thống kê, bắt buộc

            builder.Property(e => e.TotalProducts).IsRequired(); // Tổng số sản phẩm, bắt buộc

            builder.Property(e => e.TotalOrders).IsRequired(); // Tổng số đơn hàng, bắt buộc

            builder.Property(e => e.TotalRevenue).IsRequired(); // Tổng doanh thu, bắt buộc

            builder.Property(e => e.TotalProfit).IsRequired(); // Tổng lợi nhuận, bắt buộc
        }
    }
}

﻿using BaseMarket.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Configurations
{
    internal class AppAccountConfiguration : IEntityTypeConfiguration<AppAccount>
    {
        public void Configure(EntityTypeBuilder<AppAccount> builder)
        {
            builder.ToTable("AppAccount");
            // Khóa chính
            builder.HasKey(x => x.Id);
            // Sinh tự động giá trị cho khóa chính
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            // Giới hạn độ dài Fullname
            builder.Property(x => x.Fullname).HasMaxLength(100);
            // Bắt buộc phải có Token
            builder.Property(x => x.Token).IsRequired();
            // Bắt buộc phải có trạng thái Active
            builder.Property(x=> x.Active).IsRequired();
            // Giới hạn độ dài Address
            builder.Property(x=>x.Address).HasMaxLength(250);
            // Bắt buộc phải có CreateDate
            builder.Property(e => e.CreateDate).IsRequired(); 
            // Bắt buộc phải có UpdateDate
            builder.Property(e => e.UpdateDate).IsRequired();
            // Bắt buộc phải có LastLogin
            builder.Property(e => e.LastLogin).IsRequired(); 
        }
    }
}

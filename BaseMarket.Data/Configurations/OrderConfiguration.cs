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
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.HasKey(x => x.OrderID);

            builder.HasOne(x => x.TransactStatus).WithMany().HasForeignKey(x => x.TransactStatusID);

            builder.HasOne(x => x.AppUser).WithMany().HasForeignKey(x => x.UserID);
        }
    }
}

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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.ProductID);

            builder.Property(x=>x.Price).IsRequired();

            /*builder.Property(x=>x.Discount).IsRequired();*/

            builder.Property(x => x.UnitStock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.Active).HasDefaultValue(Active.Active);
        }
    }
}

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
    class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryID, t.ProductID });

            builder.ToTable("ProductInCategory");

            // RelationShip 1 -n
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(t => t.ProductID);
            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(t => t.CategoryID);
        }
    }
}

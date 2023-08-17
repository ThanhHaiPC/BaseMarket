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
    class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRole");       

            builder.Property(x =>x.Name).IsRequired().HasMaxLength(100);

            builder.Property(x=>x.ShortDesc).HasMaxLength(150);

            // Bắt buộc phải có CreateDate
            builder.Property(e => e.CreateDate).IsRequired();
            // Bắt buộc phải có UpdateDate
            builder.Property(e => e.UpdateDate).IsRequired();
        }
    }
}

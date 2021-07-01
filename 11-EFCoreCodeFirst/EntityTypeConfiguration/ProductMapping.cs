using _11_EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.EntityTypeConfiguration
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Urun");
            builder.HasKey(a => a.ProductID);
            builder.Property(a => a.ProductID).ValueGeneratedOnAdd();

            builder.Property(a => a.ProductName).HasMaxLength(50).IsRequired();
            builder.HasOne(a => a.Category).WithMany(a => a.Products).HasForeignKey(a => a.CategoryID);
        }
    }
}

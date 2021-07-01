using _11_EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_EFCoreCodeFirst.EntityTypeConfiguration
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Kategori");
            builder.HasKey(a => a.CategoryID);
            builder.Property(a => a.CategoryID).ValueGeneratedOnAdd();//Identity olarak belirledim..

            builder.Property(a => a.CategoryName).HasMaxLength(50).IsRequired().HasColumnName("KategoriAdi");
            builder.Property(a => a.Description).HasMaxLength(150).IsRequired().HasColumnName("Açıklama");
        }
    }
}

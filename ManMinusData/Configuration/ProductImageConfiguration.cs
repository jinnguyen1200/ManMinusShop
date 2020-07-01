using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManMinusData.Configuration
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable(nameof(ProductImage));
            builder.HasKey(x => x.ProductId);
            builder.HasIndex(x => new { x.ProductId, x.ImageUrl });
        }
    }
}

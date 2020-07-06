using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManMinusData.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable(nameof(Cart));
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User).WithMany(x => x.Carts).HasForeignKey(x => x.UserId);
        }
    }
}

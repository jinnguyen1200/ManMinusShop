using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManMinusData.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail));
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusData.Entities.Business
{
    public class Cart : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid UserId { get; set; }

        public Order Order { get; set; }
        public User User { get; set; }
    }
}

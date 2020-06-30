using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusData.Entities.Business
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

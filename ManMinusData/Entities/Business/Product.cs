using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusData.Entities.Business
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Details { get; set; }
        public bool IsInStock { get; set; }
    }
}

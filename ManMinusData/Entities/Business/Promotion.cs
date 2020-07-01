using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusData.Entities.Business
{
    public class Promotion : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Percent { get; set; }
        public int? Amount { get; set; }
        public bool IsApplyToAll { get; set; }
    }
}

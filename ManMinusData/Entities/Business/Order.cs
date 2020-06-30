using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Enums;

namespace ManMinusData.Entities.Business
{
    public class Order : BaseEntity
    {
        public int? CartId { get; set; }
        public int UserId { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingEmail { get; set; }
        public OrderStatusEnum Status { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string PaymentMethodDetail { get; set; }
    }
}

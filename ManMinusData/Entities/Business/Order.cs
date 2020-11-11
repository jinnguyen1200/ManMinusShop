using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Enums;

namespace ManMinusData.Entities.Business
{
    public class Order : BaseEntity
    {
        public int? CartId { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingEmail { get; set; }
        public OrderStatusEnum Status { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string PaymentMethodDetail { get; set; }
        public Guid UserId { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Cart Cart { get; set; }
        public User User { get; set; }
    }
}

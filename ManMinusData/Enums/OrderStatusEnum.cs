using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusData.Enums
{
    public enum OrderStatusEnum
    {
        New = 1,
        InProgress = 2,
        WaitingToShip = 3,
        Shipped = 4
    }

    public enum PaymentMethodEnum
    {
        Cash = 1,
        CashOnDelivery = 2,
        Card = 3
    }
}

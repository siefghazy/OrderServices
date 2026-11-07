using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Enums
{
    public enum ShippingStatus
    {
        Pending = 1,
        Preparing,
        Shipped,
        InTransit,
        Delivered,
        Failed,
        Returned
    }
}

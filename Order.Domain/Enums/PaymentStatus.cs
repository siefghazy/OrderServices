using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Enums
{
    public enum PaymentStatus
    {
        Pending = 1,
        Authorized,
        Paid,
        Failed,
        Refunded,
        PartiallyRefunded
    }
}

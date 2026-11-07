using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entites
{
    public class OrderShipment
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public string? ShippingProvider { get; set; }

        public string? TrackingNumber { get; set; }

        public ShippingStatus Status { get; set; }

        public DateTime? ShippedAt { get; set; }

        public DateTime? DeliveredAt { get; set; }

        public Order Order { get; set; } = null!;
    }
}

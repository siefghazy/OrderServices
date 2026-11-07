using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entites
{
    public class OrderStatusHistory
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public OrderStatus OldStatus { get; set; }

        public OrderStatus NewStatus { get; set; }

        public string? Reason { get; set; }

        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        public Order Order { get; set; } = null!;
    }
}

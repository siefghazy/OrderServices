using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderService.Domain.Enums;

namespace OrderService.Domain.Entites
{
    public class OrderPayment
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public string? TransactionId { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus Status { get; set; }

        public DateTime? PaidAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Order Order { get; set; } = null!;
    }
}

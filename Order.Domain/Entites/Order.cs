using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderService.Domain.Enums;

namespace OrderService.Domain.Entites
{
    public class Order
    {
        public Guid Id { get; set; }

        public string OrderNumber { get; set; } = null!;

        public Guid UserId { get; set; }

        public decimal SubTotal { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal ShippingCost { get; set; }

        public decimal TotalAmount { get; set; }

        public string Currency { get; set; } = "EGP";

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public PaymentStatus PaymentStatus { get; set; }
            = PaymentStatus.Pending;

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public ICollection<OrderItem> Items { get; set; }
            = new List<OrderItem>();

        public OrderAddress? Address { get; set; }

        public ICollection<OrderPayment> Payments { get; set; }
            = new List<OrderPayment>();

        public ICollection<OrderShipment> Shipments { get; set; }
            = new List<OrderShipment>();

        public ICollection<OrderStatusHistory> StatusHistories { get; set; }
            = new List<OrderStatusHistory>();
    }
}

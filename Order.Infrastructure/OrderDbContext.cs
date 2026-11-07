using Microsoft.EntityFrameworkCore;
using OrderService.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure
{
    public class OrderDbContext: DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }
        public DbSet<OrderService.Domain.Entites.Order> Orders { set; get; }

        public DbSet<OrderItem> OrderItems { set; get; }

        public DbSet<OrderAddress> OrderAddresses { set; get; }

        public DbSet<OrderPayment> OrderPayments { set; get; }

        public DbSet<OrderShipment> OrderShipments { set; get; }

        public DbSet<OrderStatusHistory> OrderStatusHistories { set; get; }

        public DbSet<OutboxMessage> OutboxMessages { set; get; }

        public DbSet<InboxMessage> InboxMessages { set; get; }

    }
}

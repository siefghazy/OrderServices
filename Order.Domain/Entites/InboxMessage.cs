using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entites
{
    public class InboxMessage
    {
        public Guid Id { get; set; }

        public Guid MessageId { get; set; }

        public string ConsumerName { get; set; } = null!;

        public DateTime ProcessedAt { get; set; } = DateTime.UtcNow;
    }
}

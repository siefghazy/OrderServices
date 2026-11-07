using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entites
{
    public class OutboxMessage
    {
        public Guid Id { get; set; }

        public string Type { get; set; } = null!;

        public string Payload { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ProcessedAt { get; set; }

        public int RetryCount { get; set; }
    }
}

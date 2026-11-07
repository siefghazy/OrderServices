using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entites
{
    public class OrderAddress
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public string FullName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string? BuildingNumber { get; set; }

        public string? ApartmentNumber { get; set; }

        public string? PostalCode { get; set; }

        public Order Order { get; set; } = null!;
    }
}

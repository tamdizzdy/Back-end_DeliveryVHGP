using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class CustomerBuilding
    {
        public string Id { get; set; } = null!;
        public string? BuildingId { get; set; }
        public string? CustomerId { get; set; }
        public string? Room { get; set; }
        public string? Status { get; set; }
        public string? Name { get; set; }

        public virtual Building? Building { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}

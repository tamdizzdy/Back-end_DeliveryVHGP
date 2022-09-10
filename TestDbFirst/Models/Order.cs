using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderEachShops = new HashSet<OrderEachShop>();
            TimeOfOrderStages = new HashSet<TimeOfOrderStage>();
        }

        public string Id { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? Total { get; set; }
        public string? Type { get; set; }
        public string? StatusId { get; set; }
        public string? HubId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Hub? Hub { get; set; }
        public virtual ICollection<OrderEachShop> OrderEachShops { get; set; }
        public virtual ICollection<TimeOfOrderStage> TimeOfOrderStages { get; set; }
    }
}

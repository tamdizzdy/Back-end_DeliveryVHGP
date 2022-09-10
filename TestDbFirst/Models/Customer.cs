using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerBuildings = new HashSet<CustomerBuilding>();
            Orders = new HashSet<Order>();
        }

        public string Id { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<CustomerBuilding> CustomerBuildings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

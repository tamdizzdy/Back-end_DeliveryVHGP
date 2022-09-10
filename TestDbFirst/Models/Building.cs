using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class Building
    {
        public Building()
        {
            CustomerBuildings = new HashSet<CustomerBuilding>();
            Hubs = new HashSet<Hub>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<CustomerBuilding> CustomerBuildings { get; set; }
        public virtual ICollection<Hub> Hubs { get; set; }
    }
}

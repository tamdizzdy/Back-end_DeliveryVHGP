using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class Brand
    {
        public Brand()
        {
            ShopOwners = new HashSet<ShopOwner>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<ShopOwner> ShopOwners { get; set; }
    }
}

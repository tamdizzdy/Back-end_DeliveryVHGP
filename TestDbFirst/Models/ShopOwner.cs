using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class ShopOwner
    {
        public ShopOwner()
        {
            OrderEachShops = new HashSet<OrderEachShop>();
            Products = new HashSet<Product>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? BuildingId { get; set; }
        public string? BrandId { get; set; }
        public string? Rate { get; set; }
        public string? CloseTime { get; set; }
        public string? OpenTime { get; set; }
        public string? Image { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual ICollection<OrderEachShop> OrderEachShops { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

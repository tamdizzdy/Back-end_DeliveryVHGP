using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class OrderDetail
    {
        public string Id { get; set; } = null!;
        public string? OrderEachShopId { get; set; }
        public string? ProductId { get; set; }
        public string? Quantity { get; set; }

        public virtual OrderEachShop? OrderEachShop { get; set; }
        public virtual Product? Product { get; set; }
    }
}

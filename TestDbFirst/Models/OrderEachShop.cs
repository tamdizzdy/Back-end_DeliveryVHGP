using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class OrderEachShop
    {
        public OrderEachShop()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Id { get; set; } = null!;
        public string? ShopId { get; set; }
        public string? OrderId { get; set; }
        public string? Status { get; set; }

        public virtual Order? Order { get; set; }
        public virtual ShopOwner? Shop { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

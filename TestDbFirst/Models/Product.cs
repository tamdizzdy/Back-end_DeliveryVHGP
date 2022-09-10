using System;
using System.Collections.Generic;

namespace TestDbFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
        public string? CategoryId { get; set; }
        public string? Status { get; set; }
        public string? ShopId { get; set; }
        public string? NetWeight { get; set; }

        public virtual ProductCategory? Category { get; set; }
        public virtual ShopOwner? Shop { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

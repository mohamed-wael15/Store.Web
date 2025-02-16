﻿namespace Store.Data.Entities.OrderEntities
{
    public class OrderItem : BaseEntity<Guid>
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ProductItem productItem { get; set; }
        public Guid OrderId { get; set; }
    }
}

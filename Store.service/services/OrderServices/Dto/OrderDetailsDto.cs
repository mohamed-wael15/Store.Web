﻿using Store.Data.Entities.OrderEntities;

namespace Store.service.services.OrderServices.Dto
{
    public class OrderDetailsDto
    {
        public Guid Id { get; set; }
        public string BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public AddressDto ShippingAddress { get; set; }
        public string DeliveryMethodName { get; set; }
        public OrderPaymentStatus OrderPaymentStatus { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IReadOnlyList<OrderItemDto> OrderItems { get; set; }
        public decimal SubTable { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal Total { get; set; }
        public string? BasketId { get; set; }
        public string? PaymentIntentId { get; set; }
    }
}

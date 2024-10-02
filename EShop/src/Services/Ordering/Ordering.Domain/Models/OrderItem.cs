
namespace Ordering.Domain.Models
{
    public class OrderItem : Entity<OrderItemId>
    {
        internal OrderItem(decimal price, int quantity, OrderId orderId, ProductId productId)
        {
            Id = OrderItemId.Of(Guid.NewGuid());
            Price = price;
            Quantity = quantity;
            OrderId = orderId;
            ProductId = productId;
        }

        public decimal Price { get; private set; }
        public int Quantity { get; private set; } 
        public OrderId OrderId { get; private set; }
        public ProductId ProductId { get; private set; }
    }
}

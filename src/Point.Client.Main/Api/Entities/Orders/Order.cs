using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Entities.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; } // Order Number
        public Customer? Customer { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public PaymentTerm? PaymentTerm { get; set; }
        public List<Payment>? Payments { get; set; }
    }
}

using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Entities.Orders
{
    public class Refund
    {
        public int Id { get; set; } 
        public DateTime Created { get; set; }
        public decimal Amount { get; set; }
        public PaymentMode Mode { get; set; }
        public string? Reference { get; set; }
        public string? Remarks { get; set; }
        public int OrderItemId { get; set; }
    }
}

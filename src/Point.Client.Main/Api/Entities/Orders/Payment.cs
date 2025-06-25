using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Entities.Orders
{
    public class Payment
    {
        public int Id { get; set; } // PriceId, ForeignKey
        public DateTime Created { get; set; }
        public decimal Amount { get; set; }
        public PaymentMode Mode { get; set; }
        public string? Reference { get; set; }
        public string? Remarks { get; set; }
    }
}

using Point.Client.Main.Api.Enums;

namespace Point.Client.Main.Api.Dtos
{
    public sealed class OrderDto
    {
        public int? CustomerId { get; init; }
        public decimal SubTotal { get; init; }
        public decimal Discount { get; init; }
        public decimal Total { get; init; }
        public List<OrderItemDto> Items { get; init; }
        public PaymentTerm? PaymentTerm { get; init; }
        public PaymentDto? Payment {  get; init; }
    }

    public sealed class OrderItemDto
    {
        public int ItemUnitId { get; set; }
        public string ItemName { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }

    public sealed class PaymentDto 
    {
        public decimal Amount { get; init; }
        public PaymentMode Mode { get; init; }
        public string? Reference {  get; init; }
        public string? Remarks { get; init; }
    }
}

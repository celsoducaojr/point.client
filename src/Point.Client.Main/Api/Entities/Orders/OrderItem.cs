namespace Point.Client.Main.Api.Entities.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemUnitId { get; set; }
        public string ItemName { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }
}

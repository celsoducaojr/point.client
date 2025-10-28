namespace Point.Client.Main.Api.Entities.Orders
{
    public class Customer
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remarks { get; set; }
    }
}

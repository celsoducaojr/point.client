namespace Point.Client.Main.Api.Dtos
{
    public sealed record CustomerDto
    {
        public string Name { get; init; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remarks { get; set; }
    }
}

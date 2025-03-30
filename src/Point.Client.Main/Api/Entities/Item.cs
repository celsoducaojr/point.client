namespace Point.Client.Main.Api.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public Category? Category { get; set; }
        public string? Description { get; set; }
        public List<Tag>? Tags { get; set; }
    }
}

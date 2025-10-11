namespace Point.DataManager.Dto
{
    public class ItemDto
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public List<decimal> Prices { get; set; }
    }
}

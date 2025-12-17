namespace DemoMaui.Models
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsVegan { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}

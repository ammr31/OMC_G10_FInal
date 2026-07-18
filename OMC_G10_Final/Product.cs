public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
    public string Category { get; set; }
    public string Details { get; set; }   // new — maps to Details column in Access
}
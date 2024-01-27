namespace MVC_Demo.Models.Product
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}

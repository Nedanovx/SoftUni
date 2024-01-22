using MVC_Demo.Models.Product;

namespace MVC_Demo.Seeding
{
    public static class ProductsData
    {
        public static IEnumerable<ProductViewModel> Products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Milk",
                Price = 2.19m
            },
             new ProductViewModel()
            {
                Id = Guid.NewGuid(),
				Name = "Eggs",
                Price = 5.69m
            },
              new ProductViewModel()
            {
                Id = Guid.NewGuid(),
				Name = "Bread",
                Price = 1.8m
            }
        };
    }
}

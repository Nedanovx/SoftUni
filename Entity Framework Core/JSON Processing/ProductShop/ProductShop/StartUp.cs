using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext db = new ProductShopContext();

            string userJson = File.ReadAllText("../../../Datasets/users.json");

            Console.WriteLine(ImportUsers(db, userJson));

            string productJson = File.ReadAllText("../../../Datasets/products.json");

            Console.WriteLine(ImportProducts(db, productJson));

            string categoryJson = File.ReadAllText("../../../Datasets/categories.json");

            Console.WriteLine(ImportCategories(db, categoryJson));

            string productsCategoriesJson = File.ReadAllText("../../../Datasets/categories-products.json");

            Console.WriteLine(ImportCategories(db, productsCategoriesJson));

            Console.WriteLine(GetProductsInRange(db));


        }
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<User[]>(inputJson);
            context.AddRange(users);

            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        { 
            var products = JsonConvert.DeserializeObject<Product[]>(inputJson);

            context.AddRange(products);

            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<Category[]>(inputJson);
            var validCategories = categories?.Where(c => c.Name is not null).ToArray();

            if (validCategories is not null)
            {
                context.AddRange(validCategories);
                context.SaveChanges();
                return $"Successfully imported {validCategories.Length}";
            }
            return "Successfully imported 0";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoryProducts = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);

            context.AddRange(categoryProducts);

            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Length}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var result = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                })
                .OrderBy(p => p.price)
                .ToArray();

            var resultJson = JsonConvert.SerializeObject(result, Formatting.Indented);
            return resultJson;
        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
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

            Console.WriteLine(ImportCategoryProducts(db, productsCategoriesJson));

            Console.WriteLine(GetProductsInRange(db));

            Console.WriteLine(GetSoldProducts(db));

            Console.WriteLine(GetCategoriesByProductsCount(db));

            Console.WriteLine(GetUsersWithProducts(db));


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

        public static string GetSoldProducts(ProductShopContext context)
        {
            var result = context.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                    .Where(p => p.BuyerId != null)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buyerFirstName = p.Buyer.FirstName,
                        buyerLastName = p.Buyer.LastName
                    }).ToArray()
                }).ToArray();

            string resultJson = JsonConvert.SerializeObject(result, Formatting.Indented);
            return resultJson;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var result = context.Categories
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoriesProducts.Count,
                    averagePrice = c.CategoriesProducts.Average(cp => cp.Product.Price).ToString("f2"),
                    totalRevenue = c.CategoriesProducts.Sum(cp => cp.Product.Price).ToString("f2")
                })
                .OrderByDescending(x => x.productsCount)
                .ToArray();

            string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return jsonResult;
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var result = context.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = u.ProductsSold
                    .Where(p => p.BuyerId != null)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price
                    })
                    .ToArray()
                })
                .OrderByDescending(x => x.soldProducts.Length)
                .ToArray();

            var output = new
            {
                usersCount = result.Length,
                users = result.Select(u => new
                {
                    u.firstName,
                    u.lastName,
                    u.age,
                    soldProducts = new
                    {
                        count = u.soldProducts.Length,
                        products = u.soldProducts
                    }
                })

            };

            string jsonOutput = JsonConvert.SerializeObject(output, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            return jsonOutput;
        }
    }
}
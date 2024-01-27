using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MVC_Demo.Models.Product;
using System.Text;
using System.Text.Json;
using static MVC_Demo.Seeding.ProductsData;
namespace MVC_Demo.Controllers
{
    public class ProductController : Controller
    {
        [ActionName("My-products")]
        public IActionResult All(string? keyword)
        {
            if(keyword != null) 
            {
                var foundProducts = Products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
                if(foundProducts.Any())
                {
                    return View(foundProducts);
                }             
            }
            
            return View(Products);
        }

        public IActionResult ById(string id) 
        {
            ProductViewModel? product = Products.FirstOrDefault(p => p.Id.ToString().Equals(id));

            if (product == null)
            {
                return this.RedirectToAction("All");
            }

            return View(product); 
        }

        public IActionResult AllAsJson()
        {
            return Json(Products, new JsonSerializerOptions()
            {
                WriteIndented = true,
            });
        }

        public IActionResult AllAsText()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in Products)
            {
                sb.AppendLine($"Product {item.Id}: {item.Name} - {item.Price:f2} lv.");
            }
            return Content(sb.ToString().TrimEnd());
        }

        public IActionResult AllAsTextFile()
        {
            StringBuilder sb = new();
            foreach(var item in Products)
            {
                sb.AppendLine($"{item.Id}: {item.Name} - {item.Price:f2} lv.");
            }

            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment; filename=products.txt");
            return File(Encoding.UTF8.GetBytes(sb.ToString().TrimEnd()), "text/plain");
        }
    }
}

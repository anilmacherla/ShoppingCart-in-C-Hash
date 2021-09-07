using MvcDemoProject.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcDemoProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product productModel = new Product();
            ViewBag.products = GetProducts();
            return View();
        }

        public List<Product> GetProducts()
        {
            return new List<Product>() {
                new Product {
                    ProductID = 1,
                    ProductName = "Aata",
                    Price = 500,
                    Discount = 10,
                    CategoryID = 1,
                    Category = "Food",
                    Photo = "aata.png"
                },
                new Product {
                    ProductID = 2,
                    ProductName = "Soap",
                    Price = 20,
                     Discount = 10,
                    CategoryID = 2,
                    Category = "PersonalCare",
                    Photo = "soap.jpeg"
                },
                new Product {
                    ProductID = 3,
                    ProductName = "Shampoo",
                    Price = 6, Discount = 10,
                    CategoryID = 2,
                    Category = "PersonalCare",
                    Photo = "shampoo.jpg"
                }
            };
        }

    }
}

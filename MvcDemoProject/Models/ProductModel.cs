using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemoProject.Models
{
    public class Product
    {
        
        public List<Product> products;
        public int ProductID { get; set; }
        public string ProductName { get; set; }
       // public string Brand { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        //public float DiscountedPrice => Price - (DiscountedPrice / 100);
        public string Category { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public  string Photo { get; set; }
    }
}
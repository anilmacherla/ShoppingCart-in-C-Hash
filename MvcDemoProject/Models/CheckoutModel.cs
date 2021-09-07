using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemoProject.Models
{
    public class CheckoutModel
    {
        public Product Product
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }
    }
}
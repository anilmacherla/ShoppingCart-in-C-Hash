using MvcDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemoProject.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(int id)
        {
            var products = new ProductController().GetProducts();
            if (Session["cart"] == null)
            {
                List<CheckoutModel> cart = new List<CheckoutModel>();
                cart.Add(new CheckoutModel { Product = products.Where(e=> e.ProductID ==id).FirstOrDefault(), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<CheckoutModel> cart = (List<CheckoutModel>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CheckoutModel { Product = products.Where(e => e.ProductID == id).FirstOrDefault(), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            List<CheckoutModel> cart = (List<CheckoutModel>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<CheckoutModel> cart = (List<CheckoutModel>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID.Equals(id))
                    return i;
            return -1;
        }
    }
}
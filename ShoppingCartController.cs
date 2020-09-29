using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class ShoppingcartController : Controller
    {
        private DemoEntities de = new DemoEntities();
        public ActionResult Index()
        {
            return View();
        }
        private int isExisting(int id)
        { 
            List<FlatItem> cart = (List<FlatItem>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Pr.Id == id)
                    return i;
            return -1;
        }
        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<FlatItem> cart = (List<FlatItem>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }

        public ActionResult OrderNow(int id)
        {
            if (Session["cart"] == null)
            {
                List<FlatItem> cart = new List<FlatItem>();
                cart.Add(new FlatItem(de.Products.Find(id),1));
                Session["cart"] = cart;
            }
            else
            {
                List<FlatItem> cart = (List<FlatItem>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new FlatItem(de.Products.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }

    }

    }
}
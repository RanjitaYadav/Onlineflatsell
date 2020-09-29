using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication6.Models;

namespace MvcApplication6.Controllers
{
    public class ProductController : Controller
    {
        
        private DemoEntities de = new DemoEntities();

        public ActionResult Index()
        {
            return View();
        }

    }
}

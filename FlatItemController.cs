



















































































































































































































































using MvcApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class FlatItemController : Controller
    {
        //private DemoEntities e = new DemoEntities();

        [NonAction]

        public List<FlatItem> GetFlatItemList()
        {
            return new List<FlatItem>{
                new FlatItem{
                    ID=1,
                    Name="Flat 1",
                    
                    
                    
                    
                    
                    
                    
                    Price=1000
                },
                new FlatItem{
                   
                    ID=2,
                    Name="Flat 2",
                    Price=1000


















                },
                new FlatItem{
                    ID=3,
                    Name="Flat 3",
                    Price=1000
                },
                new FlatItem{
                    ID=4,
                    Name="Flat 4",
                    Price=1000
                },
          };
        }
        public ActionResult Index()
        {
            //ViewBag.listEmployee = e.Employee.ToList();
            return View();
        }
        public ActionResult FlatItems()
        {
            var employees = from e in GetFlatItemList()
                            orderby e.ID
                            select e;
            return View(FlatItem);

        }
















        public ActionResult Index()
        {
            return View();
        }

    }
}

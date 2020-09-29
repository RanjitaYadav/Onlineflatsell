using MvcApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class OwnerController : Controller
    {
        //private DemoEntities e = new DemoEntities();

        [NonAction]

        public List<Owner> GetOwnerList()
        {
            return new List<Owner>{
                new Owner{
                    ID=1,
                    Name="Owner 1",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age=23
                },
                new Owner{
                   
                    ID=2,
                    Name="Owner 2",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                Age=45
                },
                new Owner{
                    ID=3,
                    Name="Owner 3",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age=37
                },
                new Owner{
                    ID=4,
                    Name="Owner 4",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age=26
                },
          };
        }
        public ActionResult Index()
        {
            ViewBag.listOwner = e.Owner.ToList();
            return View();
        }
        public ActionResult Owners()
        {
            var employees = from e in GetOwnerList()
                            orderby e.ID
                            select e;
            return View(Owner);

        }
        



























    }
}using MvcApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class OwnerController : Controller
    {
        //private DemoEntities e = new DemoEntities();

        [NonAction]

        public List<Owner> GetOwnerList()
        {
            return new List<Owner>{
                new Owner{
                    ID=1,
                    Name="Owner 1",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age=23
                },
                new Owner{
                   
                    ID=2,
                    Name="Owner 2",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                Age=45
                },
                new Owner{
                    ID=3,
                    Name="Owner 3",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age=37
                },
                new Owner{
                    ID=4,
                    Name="Owner 4",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age=26
                },
          };
        }
        public ActionResult Index()
        {
            ViewBag.listOwner = e.Owner.ToList();
            return View();
        }
        public ActionResult Owners()
        {
            var employees = from e in GetOwnerList()
                            orderby e.ID
                            select e;
            return View(Owner);

        }
        



























    }
}
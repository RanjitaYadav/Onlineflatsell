using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication6.Models
{
    public class Owner
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }
}
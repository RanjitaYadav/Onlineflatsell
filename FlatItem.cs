
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication6.Models
{
    public class FlatItem
    {
        private Product pr = new Product();

    public Product Pr
   {
        get { return pr; }
        set { pr = value; }
    }

        
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item() 
        { }

        public Item(Product product, int quantity)
            this.pr = product;
            this.quantity = quantity;
        
    
        public int ID { get; set; }
        public String Name { get; set; }

        public int Price { get; set; }
    }
}




























    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication6.Models
{
    public class FlatItem
    {
        private Product pr = new Product();

    public Product Pr
   {
        get { return pr; }
        set { pr = value; }
    }

        
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item() 
        { }

        public Item(Product product, int quantity)
            this.pr = product;
            this.quantity = quantity;
        
    
        public int ID { get; set; }
        public String Name { get; set; }

        public int Price { get; set; }
    }
}




























    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productAPI.models
{
    public class Product
    {

        public Product(string productName, decimal price,string description)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Description = description;
        }
        public string ProductName { set; get; }
        public decimal Price { set; get; }

        public string Description { set; get; }
    }
}

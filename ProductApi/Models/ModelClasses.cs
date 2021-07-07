using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }

    public class ProductsDb : List<Product>
    {
        public ProductsDb()
        {
            Add(new Product() { ProductId = 101, ProductName = "P1" });
            Add(new Product() { ProductId = 102, ProductName = "P2" });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCart.Model
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "p01",
                    Name = "name 1",
                    Price = 4,
                    Photo = "thumb1.jpg"
                },
                new Product
                {
                    Id = "p02",
                    Name = "name 2",
                    Price = 2,
                    Photo = "thumb2.jpg"
                },
                new Product
                {
                    Id = "p03",
                    Name = "name 3",
                    Price = 8,
                    Photo = "thumb3.jpg"
                }
            };
        }

        public List<Product> FindAll()
        {
            return Products;
        }

        public Product FindById(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}

using Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service.Services
{
    public class ProductService : IProductService
    {
        private ProductEntities db = new ProductEntities();

        public Product GetProduct(int id)
        {
            return db.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public bool SaveProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
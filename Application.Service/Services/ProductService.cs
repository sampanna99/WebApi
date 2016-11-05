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
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}
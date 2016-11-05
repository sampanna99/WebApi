using Application.Data;
using System.Collections.Generic;

namespace Application.Service.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        bool SaveProduct(Product product);
        bool UpdateProduct(Product product, int id);
        bool DeleteProduct(int id);
    }
}

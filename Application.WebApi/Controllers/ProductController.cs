﻿using Application.Data;
using Application.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Application.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService productService = new ProductService();

        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }


        public IHttpActionResult Get(int id)
        {
            var product = productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IHttpActionResult Post(Product product)
        {
            var isSave = productService.SaveProduct(product);

            if (isSave == true)
            {
                return Ok();
            }
            return BadRequest();

        }

        public IHttpActionResult Put(Product product)
        {
            var usUpdated = productService.UpdateProduct(product, product.Id);

            if (usUpdated == true)
            {
                return Ok();
            }
            return BadRequest();
        }
        public IHttpActionResult Delete(int id)
        {
            var isdeleted = productService.DeleteProduct(id);

            if (isdeleted == true)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}

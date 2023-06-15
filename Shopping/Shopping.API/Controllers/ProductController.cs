using Microsoft.AspNetCore.Mvc;
using Shopping.API.Data;
using Shopping.API.Models;
using System.Collections.Generic;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductContext.Products;
        }
    }
}

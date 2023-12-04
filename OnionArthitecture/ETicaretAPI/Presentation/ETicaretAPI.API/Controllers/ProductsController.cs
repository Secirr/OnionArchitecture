using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretAPI.Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]

        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using SampleControllers.Interfacess;

namespace SampleControllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public IProductService productService { get;}
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        public IActionResult CreateProduct(string name, string description, decimal price)
        {
            productService.CreateProduct(name, description, price);
            return Ok();
        }

        [HttpPost("by-quantity")]
        public IActionResult CreateProduct(string name, string description, decimal price, int quantity)
        {
            productService.CreateProduct(name,description, price, quantity);
            return Ok();
        }

        [HttpPut("by-quatity")]
        public IActionResult UpdateProductByQuantity(string name, int quantity)
        {
            productService.UpdateProductQuantity(name, quantity);
            return Ok($"successfully updated product quantity by {quantity}");
        }
        [HttpPost("by-price")]
        public IActionResult UpdateProductByPrice(decimal newPrice, string name)
        {
            productService.UpdateProductPrice(newPrice, name);
            return Ok("Price Updated");
        }

        [HttpGet("all-products")]
        public IActionResult GetAllProduct()
        {
           var result =  productService.GetAllProducts();
            int count = result.Count;
            
            return Ok(result.Keys.ToList());
        }

        [HttpGet("all-products-list")]
        public IActionResult GetAllProductList()
        {
            productService.GetAllProductList();
            return Ok();
        }
    }
}

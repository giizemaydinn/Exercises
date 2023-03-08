using Challenge16Business.Concrete;
using Challenge16Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge16ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductService productService = new ProductService();

        [HttpGet("getall")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await productService.GetAll();

            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("getbyid/{id:int}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await productService.GetById(id);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var result = await productService.Add(product);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var result = await productService.Update(product);

            return StatusCode(result.StatusCode, result);

        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await productService.Delete(id);

            return StatusCode(result.StatusCode, result);

        }
    }
}

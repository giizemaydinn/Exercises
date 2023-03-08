using Challenge16Business.Concrete;
using Challenge16Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge16ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        CategoryService categoryService = new CategoryService();

        [HttpGet("getall")]
        public async Task<IActionResult> GetCategories()
        {
            var result = await categoryService.GetAll();

            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("getbyid/{id:int}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var result = await categoryService.GetById(id);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPost("add")]
        public async Task<IActionResult> AddCategory(Category category)
        {
            var result = await categoryService.Add(category);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            var result = await categoryService.Update(category);

            return StatusCode(result.StatusCode, result);

        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await categoryService.Delete(id);

            return StatusCode(result.StatusCode, result);

        }
    }
}


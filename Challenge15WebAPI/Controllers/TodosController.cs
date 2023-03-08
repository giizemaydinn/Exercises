using Challenge15DataAccess;
using Challenge15Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge15WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        TodoDal todoDal = new TodoDal();
        const string table = "Todos";

        [HttpGet("getall")]
        public async Task<IActionResult> GetTodos()
        {
            var result = await todoDal.GetAll(table);//todoDal.GetAll();
            //if (result.IsSuccess)
            //{
            //    return Ok(result);
            //}

            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("getbyid/{id:int}")]
        public async Task<IActionResult> GetTodo(int id)
        {
            var result = await todoDal.GetById(id, table, "Id");//todoDal.GetById(id);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTodo(Todo todo)
        {
            var result = await todoDal.Add(todo, table);//todoDal.Add(todo);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateTodo(Todo todo)
        {
            var result = await todoDal.Update(todo, table);//todoDal.Update(todo);

            return StatusCode(result.StatusCode, result);

        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            var result = await todoDal.Delete(id, table, "Id");//todoDal.Delete(id);

            return StatusCode(result.StatusCode, result);

        }
    }
}

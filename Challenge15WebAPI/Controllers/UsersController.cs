using Challenge15DataAccess;
using Challenge15Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge15WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UserDal userDal = new UserDal();
        string table = "Users";

        [HttpGet("getall")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await userDal.GetAll(table);

            //if(result.IsSuccess)
            //{
            //    return Ok(result);
            //}

            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("getbyid/{id:int}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await userDal.GetById(id, table, "Id");
            //if (result.IsSuccess)
            //{
            //    return Ok(result);
            //}

            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser(User user)
        {
            var result = await userDal.Add(user, table);

            return StatusCode(result.StatusCode, result);

        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var result = await userDal.Update(user, table);

            return StatusCode(result.StatusCode, result);

        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await userDal.Delete(id, table, "Id");
            //if (result.IsSuccess)
            //{
            //    return Ok(result);
            //}
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}

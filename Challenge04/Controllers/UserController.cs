using AutoMapper;
using Challenge04.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Challenge04.Controllers
{
    /// <summary>
    /// AutoMapper ornegi.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public UserDto Get()
        {
            var user = new User
            {
                Id = 0,
                FirstName = "Test",
                LastName = "Test",
                isActive = true,
            };

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }
    }
}

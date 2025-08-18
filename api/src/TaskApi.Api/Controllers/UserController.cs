using Microsoft.AspNetCore.Mvc;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Domain.Exception;
using System.Threading.Tasks;

namespace TaskApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly static string _Message = "Usuário é de Preenchimento Obrigatório.";

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();

            return Ok(users.Result);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreatedUserRequest createdUserRequest)
        {
            if (createdUserRequest == null)
            {
                return BadRequest(_Message);
            }

            var userResponse = _userService.CreateUser(createdUserRequest);

            return CreatedAtAction(nameof(FindUser), userResponse.Result);
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] UpdatedUserRequest updatedUserRequest)
        {
            if (updatedUserRequest == null)
            {
                return BadRequest(_Message);
            }

            var userResponse = _userService.UpdateUser(updatedUserRequest);

            return Ok(userResponse.Result);
        }

        [HttpPost("find")]
        public async Task<IActionResult> FindUser([FromBody] FoundUserBase foundUserBase)
        {
            if (foundUserBase == null)
            {
                return BadRequest(_Message);
            }

            var userResponse = await _userService.FindUser(foundUserBase);

            return Ok(userResponse);

        }

        [HttpDelete]
        public IActionResult DeleteUser([FromBody] FoundUserBase foundUserRequest)
        {
            if (foundUserRequest == null)
            {
                return BadRequest(_Message);
            }

            _userService.DeleteUser(foundUserRequest);

            return NoContent();
        }

    }
}
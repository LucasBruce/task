using Microsoft.AspNetCore.Mvc;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.DTOs.Requests;

namespace TaskApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // private readonly IUserService userService;

        // public UserController(IUserService UserService)
        // {
        //     this.userService = UserService;
        // }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            // var users = this.userService.GetAllUsers();
            // if (users == null || !users.Result.Any())
            // {
            //     return NotFound("No users found.");
            // }

            // return Ok(users.Result);
            return Ok("Ola...");
        }

        // [HttpPost]
        // public IActionResult CreateUser([FromBody] CreatedUserRequest createdUserRequest)
        // {
        //     if (createdUserRequest == null)
        //     {
        //         return BadRequest("Invalid user data.");
        //     }

        //     var userResponse = this.userService.CreateUser(createdUserRequest);

        //     if (userResponse == null)
        //     {
        //         return BadRequest("Failed to create user.");
        //     }

        //     return CreatedAtAction(nameof(FindUser), userResponse.Result);
        // }

        // [HttpPut]
        // public IActionResult UpdateUser([FromBody] UpdatedUserRequest updatedUserRequest)
        // {
        //     if (updatedUserRequest == null)
        //     {
        //         return BadRequest("Invalid user data.");
        //     }

        //     var userResponse = this.userService.UpdateUser(updatedUserRequest);

        //     if (userResponse == null)
        //     {
        //         return NotFound("User not found.");
        //     }

        //     return Ok(userResponse.Result);
        // }

        // [HttpPost("find")]
        // public IActionResult FindUser([FromBody] FoundUserRequest foundUserRequest)
        // {
        //     if (foundUserRequest == null)
        //     {
        //         return BadRequest("Invalid user request.");
        //     }

        //     var userResponse = this.userService.FindUser(foundUserRequest);

        //     if (userResponse == null)
        //     {
        //         return NotFound("User not found.");
        //     }

        //     return Ok(userResponse.Result);
        // }

        // [HttpDelete]
        // public IActionResult DeleteUser([FromBody] FoundUserRequest foundUserRequest)
        // {
        //     if (foundUserRequest == null)
        //     {
        //         return BadRequest("Invalid user request.");
        //     }

        //     var isDeleted = this.userService.DeleteUser(foundUserRequest);

        //     if (!isDeleted.Result)
        //     {
        //         return NotFound("User not found or could not be deleted.");
        //     }

        //     return NoContent();
        // }
        
    }
}
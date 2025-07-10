using TaskApi.Api.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Api.Tests.Stubs;

namespace TaskApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetStatus()
        {
            return Ok(UserStubs.GetAll());
        }

        [HttpPost]
        public IActionResult CreateStatus()
        {
            return Ok(UserStubs.GetAll());
        }

        [HttpPut]
        public IActionResult UpdateStatus()
        {
            return Ok(UserStubs.GetAll());
        }

        [HttpPost("find")]
        public IActionResult FindStatus([FromBody] StatusRequest statusRequest)
        {
            Console.WriteLine(statusRequest);
            
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStatus()
        {
            return Ok(UserStubs.GetAll());
        }
    }
}
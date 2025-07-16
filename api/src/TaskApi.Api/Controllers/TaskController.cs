using Microsoft.AspNetCore.Mvc;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.DTOs.Requests;

namespace TaskApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = this.taskService.GetAllTasks();
            if (tasks == null || !tasks.Result.Any())
            {
                return NotFound("No tasks found.");
            }

            return Ok(tasks.Result);
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] CreatedTaskRequest createdTaskRequest)
        {
            if (createdTaskRequest == null)
            {
                return BadRequest("Invalid task data.");
            }

            var taskResponse = this.taskService.CreateTask(createdTaskRequest);

            if (taskResponse == null)
            {
                return BadRequest("Failed to create task.");
            }

            return CreatedAtAction(nameof(FindTask), taskResponse.Result);
        }

        [HttpPut]
        public IActionResult UpdateTask([FromBody] UpdatedTaskRequest updatedTaskRequest)
        {
            if (updatedTaskRequest == null)
            {
                return BadRequest("Invalid task data.");
            }

            var taskResponse = this.taskService.UpdateTask(updatedTaskRequest);

            if (taskResponse == null)
            {
                return NotFound("Task not found.");
            }

            return Ok(taskResponse.Result);
        }

        [HttpPost("find")]
        public IActionResult FindTask([FromBody] FoundTaskRequest foundTaskRequest)
        {
            if (foundTaskRequest == null)
            {
                return BadRequest("Invalid task request.");
            }

            var taskResponse = this.taskService.FindTask(foundTaskRequest);

            if (taskResponse == null)
            {
                return NotFound("Task not found.");
            }

            return Ok(taskResponse.Result);
        }

        [HttpDelete]
        public IActionResult DeleteTask( [FromBody] FoundTaskRequest foundTaskRequest)
        {
            if (foundTaskRequest == null)
            {
                return BadRequest("Invalid task request.");
            }

            var isDeleted = this.taskService.DeleteTask(foundTaskRequest);

            if (!isDeleted.Result)
            {
                return NotFound("Task not found or could not be deleted.");
            }

            return NoContent();
        }
    }
}
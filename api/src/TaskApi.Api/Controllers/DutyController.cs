using Microsoft.AspNetCore.Mvc;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.DTOs.Requests;

namespace TaskApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DutyController : ControllerBase
    {
        private readonly IDutyService _dutyService;

        public DutyController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        [HttpGet]
        public IActionResult GetAllDuties()
        {
            var duties = _dutyService.GetAllDuties();
            if (duties == null || !duties.Result.Any())
            {
                return NotFound("No duties found.");
            }

            return Ok(duties.Result);
        }

        [HttpPost]
        public IActionResult CreateDuty([FromBody] CreatedDutyRequest createdDutyRequest)
        {
            if (createdDutyRequest == null)
            {
                return BadRequest("Invalid task data.");
            }

            var dutyResponse = _dutyService.CreateDuty(createdDutyRequest);

            if (dutyResponse == null)
            {
                return BadRequest("Failed to create task.");
            }

            return CreatedAtAction(nameof(FindDuty), dutyResponse.Result);
        }

        [HttpPut]
        public IActionResult UpdateDuty([FromBody] UpdatedDutyRequest updatedDutyRequest)
        {
            if (updatedDutyRequest == null)
            {
                return BadRequest("Invalid duty data.");
            }

            var dutyResponse = _dutyService.UpdateDuty(updatedDutyRequest);

            if (dutyResponse == null)
            {
                return NotFound("Duty not found.");
            }

            return Ok(dutyResponse.Result);
        }

        [HttpPost("find")]
        public IActionResult FindDuty([FromBody] FoundDutyRequest foundDutyRequest)
        {

            var dutyResponse = _dutyService.FindDuty(foundDutyRequest);

            if (dutyResponse == null)
            {
                return NotFound("Duty not found.");
            }

            return Ok(dutyResponse.Result);
        }

        [HttpDelete]
        public IActionResult DeleteDuty( [FromBody] FoundDutyRequest foundDutyRequest)
        {
      
            var isDeleted = _dutyService.DeleteDuty(foundDutyRequest);

            if (!isDeleted.Result)
            {
                return NotFound("Duty not found or could not be deleted.");
            }

            return NoContent();
        }
    }
}
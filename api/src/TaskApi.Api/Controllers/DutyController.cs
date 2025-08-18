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

        private readonly string _Message = "Tarefa é de Preenchimento Obrigatório.";

        public DutyController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        [HttpGet]
        public IActionResult GetAllDuties()
        {
            var duties = _dutyService.GetAllDuties();

            return Ok(duties.Result);
        }

        [HttpPost]
        public IActionResult CreateDuty([FromBody] CreatedDutyRequest createdDutyRequest)
        {
            if (createdDutyRequest == null)
            {
                return BadRequest(_Message);
            }

            var dutyResponse = _dutyService.CreateDuty(createdDutyRequest);

            return CreatedAtAction(nameof(FindDuty), dutyResponse.Result);
        }

        [HttpPut]
        public IActionResult UpdateDuty([FromBody] UpdatedDutyRequest updatedDutyRequest)
        {
            if (updatedDutyRequest == null)
            {
                return BadRequest(_Message);
            }

            var dutyResponse = _dutyService.UpdateDuty(updatedDutyRequest);

            return Ok(dutyResponse.Result);
        }

        [HttpPost("find")]
        public IActionResult FindDuty([FromBody] FoundDutyBase foundDutyBase)
        {
            if (foundDutyBase == null)
            {
                return BadRequest(_Message);
            }
            var dutyResponse = _dutyService.FindDuty(foundDutyBase);

            return Ok(dutyResponse.Result);
        }

        [HttpDelete]
        public IActionResult DeleteDuty([FromBody] FoundDutyBase foundDutyBase)
        {
            _dutyService.DeleteDuty(foundDutyBase);

            return NoContent();
        }
    }
}
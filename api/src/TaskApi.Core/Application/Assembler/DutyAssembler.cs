using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Assembler
{
    public class DutyAssembler
    {
        public Duty ToDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            return new Duty
            {
                Id = updatedDutyRequest.Id,
                Title = updatedDutyRequest.Title,
                Description = updatedDutyRequest.Description,
                DueDate = updatedDutyRequest.DueDate ?? DateTime.UtcNow,
                Status = updatedDutyRequest.Status ?? new Status(),
                User = updatedDutyRequest.User ?? new User()
            };
        }
        
        public DutyResponse ToDutyResponse(Duty duty)
        {
            return new DutyResponse
            {
                Id = duty.Id,
                Title = duty.Title,
                Description = duty.Description
            };
        }

    }
}
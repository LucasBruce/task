using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IDutyService
    {
        Task<List<DutyResponse>> GetAllDuties();
        Task<DutyResponse> CreateDuty(CreatedDutyRequest createdDutyRequest);
        Task<DutyResponse> UpdateDuty(UpdatedDutyRequest updatedDutyRequest);
        Task<FoundDutyResponse> FindDuty(FoundDutyBase foundDutyBase);
        Task<bool> DeleteDuty(FoundDutyBase foundDutyBase);
    }
}
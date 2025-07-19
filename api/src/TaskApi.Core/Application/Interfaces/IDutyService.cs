using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IDutyService
    {
        Task<List<FoundDutyResponse>> GetAllDuties();
        Task<FoundDutyResponse> CreateDuty(CreatedDutyRequest createdDutyRequest);
        Task<FoundDutyResponse> UpdateDuty(UpdatedDutyRequest updatedDutyRequest);
        Task<FoundDutyResponse> FindDuty(FoundDutyRequest foundDutyRequest);
        Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest);
    }
}
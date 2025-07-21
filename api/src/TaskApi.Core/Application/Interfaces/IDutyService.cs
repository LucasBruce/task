using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IDutyService
    {
        Task<IEnumerable<DutyResponse>> GetAllDuties();
        Task<bool> CreateDuty(CreatedDutyRequest createdDutyRequest);
        Task<bool> UpdateDuty(UpdatedDutyRequest updatedDutyRequest);
        Task<FoundDutyResponse> FindDuty(FoundDutyRequest foundDutyRequest);
        Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest);
    }
}
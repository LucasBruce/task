using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IDutyRepository
    {
        Task<List<Duty>> GetAllDuties();
        Task<Duty> CreateDuty(Duty duty);
        Task<Duty> UpdateDuty(FoundDutyResponse foundDutyResponse);
        Task<Duty> FindDuty(FoundDutyRequest foundDutyRequest);
        Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest);
    }
}
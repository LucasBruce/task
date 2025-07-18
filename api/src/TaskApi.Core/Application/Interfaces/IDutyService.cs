using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IDutyService
    {
        Task<List<DutyResponse>> GetAllDuties();
        Task<DutyResponse> CreateDuty(CreatedDutyRequest createdTaskRequest);
        Task<DutyResponse> UpdateDuty(UpdatedDutyRequest updatedTaskRequest);
        Task<DutyResponse> FindDuty(FoundDutyRequest foundTaskRequest);
        Task<bool> DeleteDuty(FoundDutyRequest foundTaskRequest);
    }
}
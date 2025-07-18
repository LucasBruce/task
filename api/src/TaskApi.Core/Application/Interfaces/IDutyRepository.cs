using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IDutyRepository
    {
        Task<List<Duty>> GetAllDuties();
        Task<Duty> CreateDuty(CreatedDutyRequest createdDutyRequest);
        Task<Duty> UpdateDuty(UpdatedDutyRequest updatedDutyRequest);
        Task<Duty> FindDuty(FoundDutyRequest foundDutyRequest);
        Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest);
    }
}
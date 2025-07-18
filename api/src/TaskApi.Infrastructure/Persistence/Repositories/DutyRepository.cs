using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Infrastructure.Persistence.Repositories
{
    public class DutyRepository : IDutyRepository
    {
        public Task<Duty> CreateDuty(CreatedDutyRequest createdDutyRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest)
        {
            throw new NotImplementedException();
        }

        public Task<Duty> FindDuty(FoundDutyRequest foundDutyRequest)
        {
            throw new NotImplementedException();
        }

        public Task<List<Duty>> GetAllDuties()
        {
            throw new NotImplementedException();
        }

        public Task<Duty> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            throw new NotImplementedException();
        }
    }
}
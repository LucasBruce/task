using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Domain.Entities;
using TaskApi.Infrastructure.TestsDoubles.Stubs;

namespace TaskApi.Infrastructure.TestsDoubles.Fakes
{
    public class FakeDutyRepository : IDutyRepository
    {
        private readonly List<Duty> _duties = DutyStubs.GetAll();

        public Task<Duty> CreateDuty(CreatedDutyRequest createdDutyRequest)
        {
            var dutyResponse = new Duty
            {
                Title = createdDutyRequest.Title,
                Description = createdDutyRequest.Description,
                DueDate = createdDutyRequest.DueDate,
                Status = createdDutyRequest.Status,
            };

            _duties.Add(dutyResponse);

            return Task.FromResult(dutyResponse);
        }

        public Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest)
        {
            var duty = FindDuty(foundDutyRequest).Result;

            if (duty == null)
            {
                return Task.FromResult(false);
            }

            _duties.Remove(duty);
            
            return Task.FromResult(true);
        }

        public Task<Duty> FindDuty(FoundDutyRequest foundDutyRequest)
        {
            var duty = _duties.FirstOrDefault(t => t.Id == foundDutyRequest.Id);

            if (duty == null)
            {
                throw new DllNotFoundException("Task not found.");
            }

            return Task.FromResult(duty);
        }

        public Task<List<Duty>> GetAllDuties()
        {
            return Task.FromResult(_duties);
        }

        public Task<Duty> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            throw new NotImplementedException();
        }
    }
}
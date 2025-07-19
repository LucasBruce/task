using TaskApi.Core.Domain.Entities;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Infrastructure.TestsDoubles.Stubs;
using TaskApi.Core.Application.DTOs.Requests;

namespace TaskApi.Infrastructure.TestsDoubles.Fakes
{
    public class FakeDutyRepository : IDutyRepository
    {
        private readonly List<Duty> _duties = DutyStubs.GetAll();

        public Task<Duty> CreateDuty(Duty duty)
        {
            var dutyResponse = new Duty
            {
                Title = duty.Title,
                Description = duty.Description,
                DueDate = duty.DueDate,
                Status = duty.Status,
            };

            _duties.Add(dutyResponse);

            return Task.FromResult(dutyResponse);
        }

        public Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest)
        {
            var foundDuty = FindDuty(foundDutyRequest).Result;

            if (foundDuty == null)
            {
                return Task.FromResult(false);
            }

            _duties.Remove(foundDuty);
            
            return Task.FromResult(true);
        }

        public Task<Duty> FindDuty(FoundDutyRequest foundDutyRequest)
        {
            var foundDuty = _duties.FirstOrDefault(t => t.Id == foundDutyRequest.Id);

            if (foundDuty == null)
            {
                throw new DllNotFoundException("Task not found.");
            }

            return Task.FromResult(foundDuty);
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
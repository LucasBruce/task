using TaskApi.Core.Domain.Entities;
using TaskApi.Core.Domain.Exception;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Infrastructure.TestsDoubles.Stubs;

namespace TaskApi.Infrastructure.TestsDoubles.Fakes
{
    public class FakeDutyRepository : IDutyRepository
    {
        private readonly List<Duty> _duties = DutyStubs.GetAll();

        public Task<Duty> CreateDuty(Duty duty)
        {
            var dutyResponse = new Duty
            {
                Id = duty.Id,
                Title = duty.Title,
                Description = duty.Description,
                DueDate = duty.DueDate,
                Status = duty.Status,
                Owner = duty.Owner
            };

            _duties.Add(dutyResponse);

            return Task.FromResult(dutyResponse);
        }

        public Task<bool> DeleteDuty(FoundDutyBase foundDutyBase)
        {
            var foundDuty = FindDuty(foundDutyBase).Result;

            _duties.Remove(foundDuty);
            
            return Task.FromResult(true);
        }

        public Task<Duty> FindDuty(FoundDutyBase foundDutyBase)
        {
            Duty? foundDuty = null;

            foreach (var duty in _duties)
            {
                if (duty.Id == foundDutyBase.Id)
                {
                    foundDuty = duty;
                    break;
                }
            }

            if (foundDuty == null)
            {
                throw new DutyNotFoundException(foundDutyBase.Id);
            }

            return Task.FromResult(foundDuty);
        }

        public Task<List<Duty>> GetAllDuties()
        {
            return Task.FromResult(_duties);
        }

        public Task<Duty> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            var duty = FindDuty(updatedDutyRequest).Result;

            duty.Title = updatedDutyRequest.Title ?? duty.Title;
            duty.Description = updatedDutyRequest.Description ?? duty.Description;
            duty.DueDate = updatedDutyRequest.DueDate ?? duty.DueDate;
            duty.Status = updatedDutyRequest.Status ?? duty.Status;
            duty.Owner = updatedDutyRequest.Owner ?? duty.Owner;

            return Task.FromResult(duty);
        }
    }
}
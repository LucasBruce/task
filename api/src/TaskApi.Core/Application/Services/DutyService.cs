using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Services
{
    public class DutyService : IDutyService
    {
        private readonly IDutyRepository _dutyRepository;

        public DutyService(IDutyRepository dutyRepository)
        {
            _dutyRepository = dutyRepository;
        }

        public Task<bool> CreateDuty(CreatedDutyRequest createdDutyRequest)
        {
            var duty = _mapper.Map<Duty>(createdDutyRequest);
            var dutyResponse = _dutyRepository.CreateDuty(duty);
            var dutyRS = _mapper.Map<DutyResponse>(dutyResponse);

            return Task.FromResult(true);
     
        }

        public Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest)
        {
            var isDeleted = _dutyRepository.DeleteDuty(foundDutyRequest);

            return isDeleted;
        }

        public Task<FoundDutyResponse> FindDuty(FoundDutyRequest foundDutyRequest)
        {
            var dutyResponse = _dutyRepository.FindDuty(foundDutyRequest);

            var duty = _mapper.Map<FoundDutyResponse>(dutyResponse);

            return Task.FromResult(duty);
        }

        public async Task<IEnumerable<DutyResponse>> GetAllDuties()
        {
            var duties = await _dutyRepository.GetAllDuties();
            IEnumerable<DutyResponse> dutiesResponses = _mapper.Map<IEnumerable<DutyResponse>>(duties);

            return dutiesResponses;
        }

        public Task<bool> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            var dutyResponse = _dutyRepository.UpdateDuty(updatedDutyRequest);

            IEnumerable<DutyResponse> dutiesResponses = _mapper.Map<IEnumerable<DutyResponse>>(dutyResponse);

            return Task.FromResult(true);
        }
    }
}
